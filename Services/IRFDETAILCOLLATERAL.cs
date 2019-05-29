using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;

namespace ProjectGetPost.Services
{
    public interface IRFDETAILCOLLATERAL
    {
        Task<IEnumerable<RFDETAILCOLLATERAL>> GetByCode(string CT_CODE);
    }
}
