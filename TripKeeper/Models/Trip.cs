using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripKeeper.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        public bool IsTeamRoute { get; set; }

        public string Name { get; set; }
        public string UserId { get; set; }

        public int RouteNumber { get; set; }
        public int Tractor { get; set; }
        public string Trailer { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? StartTime { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? EndTime { get; set; }
        public decimal? StartMiles { get; set; }
        public decimal? EndingMiles { get; set; }
        //Calculating total miles on a trip
        public decimal Miles
        {
            get
            {
                if (StartMiles.HasValue && EndingMiles.HasValue)
                {
                    return EndingMiles.Value - StartMiles.Value;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Inspections { get; set; }
        public int BHPU { get; set; }
        public int XDock { get; set; }
        public decimal HourlyYard { get; set; }
        public int Chains { get; set; }

        public decimal Delay { get; set; }
        public int Sleeper { get; set; }
        public int Meals { get; set; }
        public int Pallets { get; set; }

        public int RoadStops { get; set; }
        public int SuperStops { get; set; }
        public int Shuttle { get; set; }
        public string Temp { get; set; }

        public decimal MiscExpense { get; set; }

        public string Comments { get; set; }
        public string Signature { get; set; }

        //Calculating how much a trip pays based on users input
        public decimal TotalPay
        {
            get
            {
                if (IsTeamRoute == false)
                {
                    return (Miles * 0.49m) +
                    (BHPU * 50) +
                    (XDock * 50) +
                    (HourlyYard * 22) +
                    (Chains * 15) +
                    (Delay * 22) +
                    (Sleeper * 30) +
                    (Meals * 25) +
                    (RoadStops * 18.50m) +
                    (SuperStops * 32) +
                    (Shuttle * 25) +
                    (MiscExpense * 1) +
                    (Inspections * 22) +
                    (Pallets * 1);
                }
                else
                {
                    return (Miles * 0.36m) +
                    (BHPU * 50) +
                    (XDock * 50) +
                    (HourlyYard * 22) +
                    (Chains * 15) +
                    (Delay * 22) +
                    (Sleeper * 30) +
                    (Meals * 25) +
                    (RoadStops * 9.25m) +
                    (SuperStops * 32) +
                    (Shuttle * 25) +
                    (MiscExpense * 1) +
                    (Inspections * 22) +
                    (Pallets * 1);
                }
            }
        }
    }
}