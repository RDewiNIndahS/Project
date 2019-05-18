using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;

using ProjectGetPost.Helper;

namespace ProjectGetPost.Services
{
    public class APP_MINIMUM_DESERVICE : IAPP_MINIMUM_DE
    {
        private DbContex _context;

        public APP_MINIMUM_DESERVICE(DbContex context)
        {
            _context = context;
        }

        public APP_MINIMUM_DE Create(APP_MINIMUM_DE app_minimum_de, string spousename, string IDNUMBER_SPOUSE)
        {
            DateTime localDate = DateTime.UtcNow;
            if (_context.app_minimum_de.Any(x => x.AP_REGNO == app_minimum_de.AP_REGNO))
                throw new AppException("Code \"" + app_minimum_de.AP_REGNO + "\" is already taken");
            _context.app_minimum_de.Add(app_minimum_de);
            _context.SaveChanges();
            APP_SPOUSE app_spouse = new APP_SPOUSE
            {
                AP_REGNO = app_minimum_de.AP_REGNO,
                SPOUSENAME = spousename,
                IDNUMBER_SPOUSE = IDNUMBER_SPOUSE
            };
            _context.app_spouse.Add(app_spouse);
            _context.SaveChanges();
            return app_minimum_de;
        }

        public IEnumerable<APP_MINIMUM_DE> GetAll()
        {
            return _context.app_minimum_de;
        }

        public IEnumerable<APP_JOIN> GetById(string AP_REGNO)
        {
            var data = from app_minimum in _context.app_minimum_de
                       join app_spouses in _context.app_spouse on app_minimum.AP_REGNO equals app_spouses.AP_REGNO
                       where app_minimum.AP_REGNO == AP_REGNO
                       select new APP_JOIN
                       {
                           AP_REGNO = app_minimum.AP_REGNO,
                           CUSTYPE = app_minimum.CUSTYPE,
                           IDNUMBER = app_minimum.IDNUMBER,
                           CUSTNAME = app_minimum.CUSTNAME,
                           BORNDATE = app_minimum.BORNDATE,
                           NPWP = app_minimum.NPWP,
                           NO_HP = app_minimum.NO_HP,
                           PLAFON = app_minimum.PLAFON,
                           PRODUCTTYPEID = app_minimum.PRODUCTTYPEID,
                           PRODUCTID = app_minimum.PRODUCTID,
                           MARITAL_STATUS = app_minimum.MARITAL_STATUS,
                           SPOUSENAME = app_spouses.SPOUSENAME,
                           IDNUMBER_SPOUSE = app_spouses.IDNUMBER_SPOUSE
                       };
            return data;
        }
    }
}
