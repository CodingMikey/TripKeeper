using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripKeeper.Models
{
    public class OperatorEquipment
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string UserId { get; set; }

        public int RouteNumber { get; set; }
        //EPJ = electric pallet jack
        public int Epj { get; set; }
        public string FluidLeaks { get; set; }
        public string Tires { get; set; }
        public string Forks { get; set; }
        public string HandGuards { get; set; }
        public string SafetyWarnings { get; set; }
        public string OperatorsManual { get; set; }
        public string PowerCord { get; set; }
        public string CapacityPlate { get; set; }
        public string ServiceBreak { get; set; }
        public string SteeringOperation { get; set; }
        public string DrivingControl { get; set; }
        public string HoistControl { get; set; }
        public string Horn { get; set; }
        public string LightsAlarms { get; set; }
        public string HourMeter { get; set; }
        public string BatteryIndicator { get; set; }

        public string ManualForks { get; set; }
        public string Wheels { get; set; }
        public string Maneuverability { get; set; }
        public string Handle { get; set; }
        public string ManualFluidLeaks { get; set; }
        public string ReleaseLever { get; set; }
        public string CracksWear { get; set; }

        public string HandTruckWheels { get; set; }

        public string DockCracks { get; set; }
        public string Bent { get; set; }
        public string MissingHardware { get; set; }
        public string Pins { get; set; }
        public string LiftHandleDamage { get; set; }

        public string Comments { get; set; }

        public string Signature { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }
    }
}