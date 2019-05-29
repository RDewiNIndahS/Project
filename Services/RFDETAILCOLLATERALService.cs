using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectGetPost.Services
{
    public class RFDETAILCOLLATERALService : IRFDETAILCOLLATERAL
    {
        private DbContex _context;

        public RFDETAILCOLLATERALService(DbContex context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RFDETAILCOLLATERAL>> GetByCode(string CT_CODE)
        {
            var data = await _context.rfdetailcollateral.FromSql($"EXEC GET_RFDETAILCOLLATERAL @CT_CODE={CT_CODE}").ToListAsync();
            return data;
        }
    }
}
