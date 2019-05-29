using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;

namespace ProjectGetPost.Services
{
    public interface IAPP_COLTANAHBANGUNAN
    {
        Task<IEnumerable<APP_COLTANAHBANGUNAN>> GetALL();
    }
}
