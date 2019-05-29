using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("COLLATERAL")]
    public class COLLATERAL
    {
        [Key]
        public Guid? COL_ID { get; set; }
        public string AP_REGNO { get; set; }
        public Int32? COL_SEQ { get; set; }
        public string COLLATERALTYPE { get; set; }
        public string COLLATERALOBJECT { get; set; }
        public string OWNERSHIPDOCUMENT { get; set; }
        public long? MARKETPRICE { get; set; }
        public string OWNERNAME { get; set; }
        public string OWNERSHIPDOCUMENTNUMBER { get; set; }
        public string COLLATERAL_STAT { get; set; }
        public long? PARIPASU { get; set; }
        public string COL_DESC { get; set; }
        public string ADDRESS { get; set; }
        public string IDRT { get; set; }
        public string IDRW { get; set; }
        public string IDPROVINCE { get; set; }
        public string IDCITY { get; set; }
        public string IDKECAMATAN { get; set; }
        public string IDKELURAHAN { get; set; }
        public string IDZIPCODE { get; set; }
        public string LINKDETAIL { get; set; }
        public string TABLEDETAIL { get; set; }
    }
}
