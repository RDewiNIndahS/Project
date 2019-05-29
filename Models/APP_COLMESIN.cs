using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("APP_COLMESIN")]
    public class APP_COLMESIN
    {
        [Key]
        public Guid? MESIN_ID { get; set; }
        public string AP_REGNO { get; set; }
        public DateTime? TGLTERIMADOK { get; set; }
        public DateTime? SURVEYDATE { get; set; }
        public DateTime? ASSESSMENTDATE { get; set; }
        public string ASSESSMENTNAME { get; set; }
        public string MACHINENAME { get; set; }
        public string INVOICENUMB { get; set; }
        public string COLMERK { get; set; }
        public Int32? PRODUCTIONYEAR { get; set; }
        public double? MARKETVALUE { get; set; }
        public long? LTV { get; set; }
        public double? VALUELIQUIDATION { get; set; }
        public string POTENSIESKALASI { get; set; }
        public string STATUSKEPEMILIKANJAMINAN { get; set; }
        public string LEVELNILAIJAMINAN { get; set; }
    }
}
