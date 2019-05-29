using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectGetPost.Services
{
    public class APP_COLSURATBERHARGAService : IAPP_COLSURATBERHARGA
    {
        private DbContex _context;

        public APP_COLSURATBERHARGAService(DbContex context)
        {
            _context = context;
        }

        public async Task<IEnumerable<APP_COLSURATBERHARGA>> GetALL()
        {
            var data = await _context.app_suratberharga.FromSql("EXEC GET_APPCOLSURATBERHARGA").ToListAsync();
            return data;
        }
    }
}
