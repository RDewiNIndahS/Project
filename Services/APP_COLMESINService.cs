using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectGetPost.Services
{
    public class APP_COLMESINService : IAPP_COLMESIN
    {
        private DbContex _context;

        public APP_COLMESINService(DbContex context)
        {
            _context = context;
        }
        public async Task<IEnumerable<APP_COLMESIN>> GetALL()
        {
            var data = await _context.app_colmesin.FromSql("EXEC GET_APPCOLMESIN").ToListAsync();
            return data;
        }
    }
}
