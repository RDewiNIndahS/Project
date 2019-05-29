using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectGetPost.Models
{
    [Table("APP_COLTANAHBANGUNAN")]
    public class APP_COLTANAHBANGUNAN
    {
        [Key]
        public string AP_REGNO { get; set; }
        public Guid? TANAHBANGUNAN_ID { get; set; }
        public DateTime? TGLTERIMADOK { get; set; }
        public DateTime? SURVEYDATE { get; set; }
        public DateTime? ASSESSMENTDATE { get; set; }
        public string ASSESSMENTNAME { get; set; }
        public DateTime? TGLTERBITSERTIF { get; set; }
        public DateTime? DUEDATE { get; set; }
        public string COLLEGALITY { get; set; }
        public string COLDESIGN { get; set; }
        public string COLFUNCTION { get; set; }
        public string FRONT { get; set; }
        public string BACK { get; set; }
        public string BATASKANAN { get; set; }
        public string BATASKIRI { get; set; }
        public double? SURFACEAREA { get; set; }
        public string BUILDINGPERMIT { get; set; }
        public DateTime? DATEBUILDINGPERMIT { get; set; }
        public Int32? YEARESTABLISHED { get; set; }
        public Int32? YEARRENOVATION { get; set; }
        public Int32? TOTALFLOORS { get; set; }
        public string KONDISIKESELURUHANBANGUNAN { get; set; }
        public double? SFMARKETVALUE { get; set; }
        public double? SFVALUELIQUIDATION { get; set; }
        public double? TOTALCOLLIQVALUE { get; set; }
        public double? BLDMARKETVALUE { get; set; }
        public double? BLDVALUELIQUIDATION { get; set; }
        public string BUILDINGFOUNDATION { get; set; }
        public string BUILDINGFLOOR { get; set; }
        public string RANGKABANGUNAN { get; set; }
        public string BUILDINGWALL { get; set; }
        public string BUILDINGROOF { get; set; }
        public Int32? BUILDINGELECTRICITY { get; set; }
        public string PDAM { get; set; }
        public string BUILDINGPHONE { get; set; }
        public string JENISPENGIKATAN { get; set; }
        public double? NILAIPENGIKATAN { get; set; }
        public string NOASURANSIKEBAKARAN { get; set; }
        public double? HARGAPBB { get; set; }
        public double? HARGAPEMDA { get; set; }
        public string PRICEDESC { get; set; }
        public double? LENGTHBLD { get; set; }
        public double? WIDTHBLD { get; set; }
        public double? BLDAREA { get; set; }
        public double? HARGAPEMDABLD { get; set; }
        public double? HARGAPBBBLD { get; set; }
        public string PRICEDESCBLD { get; set; }
        public double? LANDLENGTH { get; set; }
        public double? WIDTHLAND { get; set; }
        public string NOSHMSHGB { get; set; }
        public string OWNEWSHMSHGB { get; set; }
        public string PENJUAL { get; set; }
        public string NOSUGS { get; set; }
        public DateTime? DATESUGS { get; set; }
        public string KANTORPERTAHANAN { get; set; }
        public DateTime? TGLKANTORPERTAHANAN { get; set; }
    }
}
