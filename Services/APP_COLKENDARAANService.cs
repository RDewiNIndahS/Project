using ProjectGetPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectGetPost.Services
{
    public class APP_COLKENDARAANService : IAPP_COLKENDARAAN
    {
        private DbContex _context;

        public APP_COLKENDARAANService(DbContex context)
        {
            _context = context;
        }

        public async Task<IEnumerable<APP_COLKENDARAAN>> GetALL()
        {
            var data = await _context.app_colkendaraan.FromSql("EXEC GET_APPCOLKENDARAAN").ToListAsync();
            return data;
        }
    }
}
