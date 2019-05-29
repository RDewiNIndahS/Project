using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("APP_COLKENDARAAN")]
    public class APP_COLKENDARAAN
    {
        [Key]
        public Guid? KENDARAAN_ID { get; set; }
        public string AP_REGNO { get; set; }
        public DateTime? TGLTERIMADOK { get; set; }
        public DateTime? SURVEYDATE { get; set; }
        public DateTime? ASSESSMENTDATE { get; set; }
        public string ASSESSMENTNAME { get; set; }
        public string TRANSPORTATIONTYPE { get; set; }
        public string STATOWNERSHIP { get; set; }
        public string OWNERNAME { get; set; }
        public string NUMBBPKP { get; set; }
        public string POLICENUMB { get; set; }
        public string RANGKAMESIN { get; set; }
        public string ENGINENUMB { get; set; }
        public string COLBRAND { get; set; }
        public string COLMODEL { get; set; }
        public Int32? PRODUCTIONYEAR { get; set; }
        public string NUMBNOTEBPKP { get; set; }
        public DateTime? DATECNBPKB { get; set; }
        public DateTime? DATEJTCNBPKB { get; set; }
        public DateTime? BLOCKINGDATE { get; set; }
        public DateTime? JTBLOCKINGDATE { get; set; }
        public string CONDITION { get; set; }
        public long? KILOMETERS { get; set; }
        public long? CYLINDERS { get; set; }
        public string TRANSMISSION { get; set; }
        public string COLOR { get; set; }
        public long? MARKETVALUE { get; set; }
        public long? LTV { get; set; }
        public long? VALUELIQUIDATION { get; set; }
        public string POTENSIESKALASI { get; set; }
        public string STATUSKEPEMILIKANJAMINAN { get; set; }
        public string LEVELNILAIJAMINAN { get; set; }
    }
}
