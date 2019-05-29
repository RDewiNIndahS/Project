using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("RFCOLTYPE")]
    public class RFCOLTYPE
    {
        [Key]
        public string CT_CODE { get; set; }
        public string CT_DESC { get; set; }
        public string CORE_CODE { get; set; }
        public bool ACTIVE { get; set; }
        public string COL_TYPE { get; set; }
        public Int32? MAX_LTCR { get; set; }
    }
}
