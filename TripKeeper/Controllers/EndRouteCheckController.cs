using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TripKeeper.Data;
using TripKeeper.Models;

namespace TripKeeper.Controllers
{
    public class EndRouteCheckController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EndRouteCheckController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: EndRouteCheck
        [Authorize]
        public async Task<IActionResult> Index()
        {
            string userId = _userManager.GetUserId(HttpContext.User);

            var endRouteChecks = await _context.EndRouteCheck.Where(a => a.UserId == userId).ToListAsync();

            return View(endRouteChecks);
            //return View(await _context.EndRouteCheck.ToListAsync());
        }

        // GET: EndRouteCheck/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endRouteCheck = await _context.EndRouteCheck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (endRouteCheck == null)
            {
                return NotFound();
            }

            return View(endRouteCheck);
        }

        // GET: EndRouteCheck/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EndRouteCheck/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Name,Tractor,Epj,Date,Trailer,RouteNumber,LoadQualitySurvey,TurnInBols,TurnInAllPaperwork,PalletJack,ReturnMisPicks,ClearTrailer,SweepTrailer,ReportTrailer,RetunDvir,ReportEquipmentDamages,StrapsHanding,TrailerShuttle,TrailerLocation,DriverSignature")] EndRouteCheck endRouteCheck)
        {
            if (ModelState.IsValid)
            {
                //Grabbing logged in users id
                string userId = _userManager.GetUserId(HttpContext.User);

                //Adding logged in users trip information
                ApplicationUser user = _context.Users.Where(a => a.Id == userId).FirstOrDefault();

                //Assigning trip user ID to the logged in users ID so we can keep track of all trips created
                endRouteCheck.UserId = user.Id;

                //Assigning the name of the logged in user to the trip full name field 
                endRouteCheck.Name = user.FirstName + " " + user.LastName;

                _context.Add(endRouteCheck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(endRouteCheck);
        }

        // GET: EndRouteCheck/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endRouteCheck = await _context.EndRouteCheck.FindAsync(id);
            if (endRouteCheck == null)
            {
                return NotFound();
            }
            return View(endRouteCheck);
        }

        // POST: EndRouteCheck/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Name,Tractor,Epj,Date,Trailer,RouteNumber,LoadQualitySurvey,TurnInBols,TurnInAllPaperwork,PalletJack,ReturnMisPicks,ClearTrailer,SweepTrailer,ReportTrailer,RetunDvir,ReportEquipmentDamages,StrapsHanding,TrailerShuttle,TrailerLocation,DriverSignature")] EndRouteCheck endRouteCheck)
        {
            if (id != endRouteCheck.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(endRouteCheck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EndRouteCheckExists(endRouteCheck.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(endRouteCheck);
        }

        // GET: EndRouteCheck/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endRouteCheck = await _context.EndRouteCheck
                .FirstOrDefaultAsync(m => m.Id == id);
            if (endRouteCheck == null)
            {
                return NotFound();
            }

            return View(endRouteCheck);
        }

        // POST: EndRouteCheck/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var endRouteCheck = await _context.EndRouteCheck.FindAsync(id);
            _context.EndRouteCheck.Remove(endRouteCheck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EndRouteCheckExists(int id)
        {
            return _context.EndRouteCheck.Any(e => e.Id == id);
        }
    }
}
