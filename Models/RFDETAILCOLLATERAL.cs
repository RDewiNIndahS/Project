using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("RFDETAILCOLLATERAL")]
    public class RFDETAILCOLLATERAL
    {
        [Key]
        public string DETCOL_CODE { get; set; }
        public string DETCOL_DESC { get; set; }
        public string CT_CODE { get; set; }
        public bool ACTIVE { get; set; }
    }
}
