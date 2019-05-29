using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectGetPost.Services
{
    public class APP_COLTANAHBANGUNANService : IAPP_COLTANAHBANGUNAN
    {
        private DbContex _context;

        public APP_COLTANAHBANGUNANService(DbContex context)
        {
            _context = context;
        }

        public async Task<IEnumerable<APP_COLTANAHBANGUNAN>> GetALL()
        {
            var data = await _context.app_tanahbangunan.FromSql("EXEC GET_APPCOLTANAHBANGUNAN").ToListAsync();
            return data;
        }
    }
}
