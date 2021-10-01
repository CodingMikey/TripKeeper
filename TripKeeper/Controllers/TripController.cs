using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
    public class TripController : Controller
    {
        private readonly ApplicationDbContext _context;
        //Using the UserManager to accesss logged in users information
        private readonly UserManager<ApplicationUser> _userManager;

        public TripController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Trip
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //Grabbing logged in users ID
            string userId = _userManager.GetUserId(HttpContext.User);

            //Assigning trips to individual user Ids
            var trips = await _context.Trip.Where(t => t.UserId == userId).ToListAsync();



            //Returning a view for the logged in users account
            //Thread.Sleep(3000);
            return View(trips);

            //return View(await _context.Trip.ToListAsync());
        }

        // GET: Trip/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.Trip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        // GET: Trip/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trip/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsTeamRoute,Name,UserId,RouteNumber,Tractor,Trailer,StartTime,EndTime,StartMiles,EndingMiles,Inspections,BHPU,XDock,HourlyYard,Chains,Delay,Sleeper,Meals,Pallets,RoadStops,SuperStops,Shuttle,Temp,MiscExpense,Comments,Signature")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                //Grabbing logged in users id
                string userId = _userManager.GetUserId(HttpContext.User);

                //Adding logged in users trip information
                ApplicationUser user = _context.Users.Where(a => a.Id == userId).FirstOrDefault();

                //Assigning trip user ID to the logged in users ID so we can keep track of all trips created
                trip.UserId = user.Id;

                //Assigning the name of the logged in user to the trip full name field 
                trip.Name = user.FirstName + " " + user.LastName;

                _context.Add(trip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trip);
        }

        // GET: Trip/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.Trip.FindAsync(id);
            if (trip == null)
            {
                return NotFound();
            }
            return View(trip);
        }

        // POST: Trip/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsTeamRoute,Name,UserId,RouteNumber,Tractor,Trailer,StartTime,EndTime,StartMiles,EndingMiles,Inspections,BHPU,XDock,HourlyYard,Chains,Delay,Sleeper,Meals,Pallets,RoadStops,SuperStops,Shuttle,Temp,MiscExpense,Comments,Signature")] Trip trip)
        {
            if (id != trip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Grabbing logged in users id
                    string userId = _userManager.GetUserId(HttpContext.User);

                    //Adding logged in users trip information
                    ApplicationUser user = _context.Users.Where(a => a.Id == userId).FirstOrDefault();

                    //Assigning trip user ID to the logged in users ID so we can keep track of all trips created
                    trip.UserId = user.Id;

                    //Assigning the name of the logged in user to the trip full name field 
                    trip.Name = user.FirstName + " " + user.LastName;

                    _context.Update(trip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TripExists(trip.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("~/OperatorEquipment/Create");
            }
            return View(trip);
        }

        // GET: Trip/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trip = await _context.Trip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        // POST: Trip/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trip = await _context.Trip.FindAsync(id);
            _context.Trip.Remove(trip);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TripExists(int id)
        {
            return _context.Trip.Any(e => e.Id == id);
        }
    }
}
