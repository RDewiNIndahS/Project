using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectGetPost.Services
{
    public class RFCOLTYPEService : IRFCOLTYPE
    {
        private DbContex _context;

        public RFCOLTYPEService(DbContex context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RFCOLTYPE>> GetAll()
        {
            var data = await _context.rfcoltype.FromSql("EXEC GET_ALLRFCOLTYPE").ToListAsync();
            return data;
        }
    }
}
