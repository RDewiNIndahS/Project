using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;
using ProjectGetPost.Helper;

namespace ProjectGetPost.Services
{
    public interface IAPP_MINIMUM_DE
    {
        IEnumerable<APP_MINIMUM_DE> GetAll();
        IEnumerable<APP_JOIN> GetById(string AP_REGNO);
        APP_MINIMUM_DE Create(APP_MINIMUM_DE app_minimum_de, string spousename, string IDNUMBER_SPOUSE);
    }
}
