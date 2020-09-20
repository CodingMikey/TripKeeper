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
    public class OperatorEquipmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public OperatorEquipmentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: OperatorEquipment
        [Authorize]
        public async Task<IActionResult> Index()
        {
            string userId = _userManager.GetUserId(HttpContext.User);

            var operatorEquipments = await _context.OperatorEquipment.Where(o => o.UserId == userId).ToListAsync();

            return View(operatorEquipments);
            //return View(await _context.OperatorEquipment.ToListAsync());
        }

        // GET: OperatorEquipment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operatorEquipment = await _context.OperatorEquipment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operatorEquipment == null)
            {
                return NotFound();
            }

            return View(operatorEquipment);
        }

        // GET: OperatorEquipment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OperatorEquipment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UserId,RouteNumber,Epj,FluidLeaks,Tires,Forks,HandGuards,SafetyWarnings,OperatorsManual,PowerCord,CapacityPlate,ServiceBreak,SteeringOperation,DrivingControl,HoistControl,Horn,LightsAlarms,HourMeter,BatteryIndicator,ManualForks,Wheels,Maneuverability,Handle,ManualFluidLeaks,ReleaseLever,CracksWear,HandTruckWheels,DockCracks,Bent,MissingHardware,Pins,LiftHandleDamage,Comments,Signature,Date")] OperatorEquipment operatorEquipment)
        {
            if (ModelState.IsValid)
            {

                //Grabbing logged in users id
                string userId = _userManager.GetUserId(HttpContext.User);

                
                ApplicationUser user = _context.Users.Where(a => a.Id == userId).FirstOrDefault();

                //The most recent trip route number
                var mostRecentRouteNumber = _context.Trip.Where(t => t.UserId == userId).OrderByDescending(x => x.StartTime).FirstOrDefault();

                if (mostRecentRouteNumber == null)
                {
                    // user loaded page but doesn't have any trips in their history
                    return View();
                }

                //Assigning the route number here from most recent trip
                operatorEquipment.RouteNumber = mostRecentRouteNumber.RouteNumber;

                //Assigning user ID to the logged in users ID
                operatorEquipment.UserId = user.Id;

                //Assigning the name of the logged in user 
                operatorEquipment.Name = user.FirstName + " " + user.LastName;

                _context.Add(operatorEquipment);
                await _context.SaveChangesAsync();
                return Redirect("~/DotAudit/Create");
            }
            return View(operatorEquipment);
        }

        // GET: OperatorEquipment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operatorEquipment = await _context.OperatorEquipment.FindAsync(id);
            if (operatorEquipment == null)
            {
                return NotFound();
            }
            return View(operatorEquipment);
        }

        // POST: OperatorEquipment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,UserId,RouteNumber,Epj,FluidLeaks,Tires,Forks,HandGuards,SafetyWarnings,OperatorsManual,PowerCord,CapacityPlate,ServiceBreak,SteeringOperation,DrivingControl,HoistControl,Horn,LightsAlarms,HourMeter,BatteryIndicator,ManualForks,Wheels,Maneuverability,Handle,ManualFluidLeaks,ReleaseLever,CracksWear,HandTruckWheels,DockCracks,Bent,MissingHardware,Pins,LiftHandleDamage,Comments,Signature,Date")] OperatorEquipment operatorEquipment)
        {
            if (id != operatorEquipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operatorEquipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperatorEquipmentExists(operatorEquipment.Id))
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
            return View(operatorEquipment);
        }

        // GET: OperatorEquipment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operatorEquipment = await _context.OperatorEquipment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operatorEquipment == null)
            {
                return NotFound();
            }

            return View(operatorEquipment);
        }

        // POST: OperatorEquipment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var operatorEquipment = await _context.OperatorEquipment.FindAsync(id);
            _context.OperatorEquipment.Remove(operatorEquipment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperatorEquipmentExists(int id)
        {
            return _context.OperatorEquipment.Any(e => e.Id == id);
        }
    }
}
