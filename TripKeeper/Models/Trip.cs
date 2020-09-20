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

        public int RouteNumber { get; set; } = 0;
        public int Tractor { get; set; } = 0;
        public string Trailer { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? StartTime { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? EndTime { get; set; }
        public decimal? StartMiles { get; set; } = 0;
        public decimal? EndingMiles { get; set; } = 0;
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

        public int Inspections { get; set; } = 0;
        public int BHPU { get; set; } = 0;
        public int XDock { get; set; } = 0;
        public decimal HourlyYard { get; set; } = 0;
        public int Chains { get; set; } = 0;

        public decimal Delay { get; set; } = 0;
        public int Sleeper { get; set; } = 0;
        public int Meals { get; set; } = 0;
        public int Pallets { get; set; } = 0;

        public int RoadStops { get; set; } = 0;
        public int SuperStops { get; set; } = 0;
        public int Shuttle { get; set; } = 0;
        public string Temp { get; set; } 

        public decimal MiscExpense { get; set; } = 0;

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
                    (Delay * 24.75m) +
                    (Sleeper * 30) +
                    (Meals * 25) +
                    (RoadStops * 19) +
                    (SuperStops * 32) +
                    (Shuttle * 25) +
                    (MiscExpense * 1) +
                    (Inspections * 24.75m) +
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
                    (RoadStops * 8) +
                    (SuperStops * 32) +
                    (Shuttle * 25) +
                    (MiscExpense * 1) +
                    (Inspections * 24.75m) +
                    (Pallets * 1);
                }
            }
        }
    }
}

//NOTES TO RESET DATABASE

//    DBCC CHECKIDENT('[TestTable]', RESEED, 0);
//GO

//DELETE FROM employees