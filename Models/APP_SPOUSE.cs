using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("APP_SPOUSE")]
    public class APP_SPOUSE
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string AP_REGNO { get; set; }
        public string SPOUSENAME { get; set; }
        public string IDNUMBER_SPOUSE { get; set; }
        public DateTime? BORNDATE_SPOUSE { get; set; }
        public string BORNPLACE_SPOUSE { get; set; }
        public string NPWP_SPOUSE { get; set; }
        public string NO_HP_SPOUSE { get; set; }
        public string ID_JOB_CATEGORY_SPOUSE { get; set; }
        public string ID_CATEGORYBU_SPOUSE { get; set; }
        public string ID_TYPEBU_SPOUSE { get; set; }
        public string CITIZENSHIP_SPOUSE { get; set; }
        public string AGAMA_ID_SPOUSE { get; set; }
        public string IDADDRESS_SPOUSE { get; set; }
        public string IDRT_SPOUSE { get; set; }
        public string IDRW_SPOUSE { get; set; }
        public string IDPROVINCE_SPOUSE { get; set; }
        public string IDCITY_SPOUSE { get; set; }
        public string IDKECAMATAN_SPOUSE { get; set; }
        public string IDKELURAHAN_SPOUSE { get; set; }
    }
}
