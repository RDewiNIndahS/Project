using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("APP_OTHERCOLDETAILS")]
    public class APP_OTHERCOLDETAILS
    {
        [Key]
        public Guid? OTHERCOLDETAILS_ID { get; set; }
        public int SEQ { get; set; }
        public string AP_REGNO { get; set; }
        public string COL_NAMEORMERK { get; set; }
        public int COL_TOTAL { get; set; }
        public double? COL_MARKETVALUE { get; set; }
        public double? COL_LTV { get; set; }
        public double? COL_VALUELIQUIDATION { get; set; }
        public string COL_DESC { get; set; }
        public string COLIND_ID { get; set; }
        public string POTENSIESKALASI { get; set; }
        public string STATUSKEPEMILIKANJAMINAN { get; set; }
        public string LEVELNILAIJAMINAN { get; set; }
    }
}
