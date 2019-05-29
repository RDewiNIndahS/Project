using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("APP_COLSURATBERHARGA")]
    public class APP_COLSURATBERHARGA
    {
        [Key]
        public Guid? SURATBERHARGA_ID { get; set; }
        public string AP_REGNO { get; set; }
        public DateTime? TGLTERIMADOK { get; set; }
        public DateTime? SURVEYDATE { get; set; }
        public DateTime? ASSESSMENTDATE { get; set; }
        public string ASSESSMENTNAME { get; set; }
        public string TYPESURATBERHARGA { get; set; }
        public string NUMBSURATBERHARGA { get; set; }
        public string OWNERNAME { get; set; }
        public DateTime? DATESURATBERHARGA { get; set; }
        public double? MARKETVALUE { get; set; }
        public double? LTV { get; set; }
        public double? VALUELIQUIDATION { get; set; }
        public string NOKATUPEGAWAI { get; set; }
        public DateTime? TGLKARTUPEGAWAI { get; set; }
        public string NOBPJS { get; set; }
        public DateTime? TGLBPJS { get; set; }
        public string NOSKKEPANGKATAN { get; set; }
        public DateTime? TGLSKKEPANGKATAN { get; set; }
        public string NOSKPEGAWAITTP { get; set; }
        public DateTime? TGLSKPEGAWAITTP { get; set; }
        public string NOSKPENGANGKATAN { get; set; }
        public DateTime? TGLSKPENGANGKATAN { get; set; }
        public string KETERANGAN { get; set; }
        public string POTENSIESKALASI { get; set; }
        public string STATUSKEPEMILIKANJAMINAN { get; set; }
        public string LEVELNILAIJAMINAN { get; set; }
    }
}
