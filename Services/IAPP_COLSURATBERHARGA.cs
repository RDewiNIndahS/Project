using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;

namespace ProjectGetPost.Services
{
    public interface IAPP_COLSURATBERHARGA
    {
        Task<IEnumerable<APP_COLSURATBERHARGA>> GetALL();
    }
}
