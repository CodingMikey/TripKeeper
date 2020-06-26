using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripKeeper.Models
{
    public class DotAudit
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public int Tractor { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }

        public bool DriversLicense { get; set; }

        public bool DotCard { get; set; }
        public bool ExtraLogBook { get; set; }
        public bool PitCard { get; set; }
        public bool Tablet { get; set; }
        public bool DvirBook { get; set; }
        public bool Registration { get; set; }
        public bool InsuranceCard { get; set; }
        public bool Ifta { get; set; }
        public bool LogBook { get; set; }
        public bool EldGuide { get; set; }
        public bool PermitBook { get; set; }
        public bool PostAccidentKit { get; set; }
        public bool BlankAccidentReport { get; set; }
        public bool OregonFuelPermit { get; set; }

        public string DriverSignature { get; set; }
    }
}