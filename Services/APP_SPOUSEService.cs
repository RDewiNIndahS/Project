using ProjectGetPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Helper;


namespace ProjectGetPost.Services
{
    public class APP_SPOUSEService : IAPP_SPOUSE
    {
        private DbContex _context;

        public APP_SPOUSEService(DbContex context)
        {
            _context = context;
        }
        
        public IEnumerable<APP_SPOUSE> GetByAll()
        {
            return _context.app_spouse;
        }
        
    }
}
