using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;

namespace ProjectGetPost.Services
{
    public interface ICOLLATERAL
    {
        Task<IEnumerable<COLLATERAL>> GetAll();
        COLLATERAL Create(COLLATERAL collateral);
    }
}
