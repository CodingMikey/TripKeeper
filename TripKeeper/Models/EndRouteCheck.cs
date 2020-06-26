using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripKeeper.Models
{
    public class EndRouteCheck
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Tractor { get; set; }
        //EPJ = electric pallet jack
        public int Epj { get; set; }
        public DateTime Date { get; set; }
        public string Trailer { get; set; }
        public int RouteNumber { get; set; }

        public string LoadQualitySurvey { get; set; }
        public string TurnInBols { get; set; }
        public string TurnInAllPaperwork { get; set; }
        public string PalletJack { get; set; }
        public string ReturnMisPicks { get; set; }
        public string ClearTrailer { get; set; }
        public string SweepTrailer { get; set; }
        public string ReportTrailer { get; set; }
        public string RetunDvir { get; set; }
        public string ReportEquipmentDamages { get; set; }
        public string StrapsHanding { get; set; }
        public string TrailerShuttle { get; set; }
        public string TrailerLocation { get; set; }

        public string DriverSignature { get; set; }

        //public string OfficeSignature { get; set; }
    }
}