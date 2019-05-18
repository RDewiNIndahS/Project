using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("APP_MINIMUM_DE")]
    public class APP_MINIMUM_DE
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string AP_REGNO { get; set; }
        public string CUSTYPE { get; set; }
        public string IDNUMBER { get; set; }
        public string CUSTNAME { get; set; }
        public DateTime? BORNDATE { get; set; }
        public string NPWP { get; set; }
        public string NO_HP { get; set; }
        public double? PLAFON { get; set; }
        public string PRODUCTTYPEID { get; set; }
        public string PRODUCTID { get; set; }
        public string MARITAL_STATUS { get; set; }
    }
}
