using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public class DotAuditController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DotAuditController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: DotAudit
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //Grabbing logged in users id
            string userId = _userManager.GetUserId(HttpContext.User);

            var dotAudits = await _context.DotAudit.Where(t => t.UserId == userId).ToListAsync();

            return View(dotAudits);

            //return View(await _context.DotAudit.ToListAsync());
        }

        // GET: DotAudit/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dotAudit = await _context.DotAudit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dotAudit == null)
            {
                return NotFound();
            }

            return View(dotAudit);
        }

        // GET: DotAudit/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DotAudit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UserId,Tractor,Date,DriversLicense,DotCard,ExtraLogBook,PitCard,Tablet,DvirBook,Registration,InsuranceCard,Ifta,LogBook,EldGuide,PermitBook,PostAccidentKit,BlankAccidentReport,OregonFuelPermit,DriverSignature")] DotAudit dotAudit)
        {
            if (ModelState.IsValid)
            {
                //Grabbing logged in users id so when they post the data goes into their account
                string userId = _userManager.GetUserId(HttpContext.User);

                
                ApplicationUser user = _context.Users.Where(a => a.Id == userId).FirstOrDefault();

                // get the user's most recent trip, sorted by the trip start date
                var mostRecentTrip = _context.Trip.Where(t => t.UserId == userId).OrderByDescending(x => x.StartTime).FirstOrDefault();

                if (mostRecentTrip == null)
                {
                    // user loaded page but doesn't have any trips in their history
                    return View();
                }

                // Setting tractor number to the number that was used from that specific trip
                dotAudit.Tractor = mostRecentTrip.Tractor;

                dotAudit.UserId = user.Id;

                //Setting the name of the logged in user into the DotAudit form
                dotAudit.Name = user.FirstName + " " + user.LastName;

                _context.Add(dotAudit);
                await _context.SaveChangesAsync();
                return Redirect("~/EndRouteCheck/Create");
            }
            return View(dotAudit);
        }

        // GET: DotAudit/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dotAudit = await _context.DotAudit.FindAsync(id);
            if (dotAudit == null)
            {
                return NotFound();
            }
            return View(dotAudit);
        }

        // POST: DotAudit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,UserId,Tractor,Date,DriversLicense,DotCard,ExtraLogBook,PitCard,Tablet,DvirBook,Registration,InsuranceCard,Ifta,LogBook,EldGuide,PermitBook,PostAccidentKit,BlankAccidentReport,OregonFuelPermit,DriverSignature")] DotAudit dotAudit)
        {
            if (id != dotAudit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dotAudit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DotAuditExists(dotAudit.Id))
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
            return View(dotAudit);
        }

        // GET: DotAudit/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dotAudit = await _context.DotAudit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dotAudit == null)
            {
                return NotFound();
            }

            return View(dotAudit);
        }

        // POST: DotAudit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dotAudit = await _context.DotAudit.FindAsync(id);
            _context.DotAudit.Remove(dotAudit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DotAuditExists(int id)
        {
            return _context.DotAudit.Any(e => e.Id == id);
        }
    }
}
