using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectGetPost.Models;

namespace ProjectGetPost.Services
{
    public interface IAPP_OTHERCOLDETAILS
    {
        Task<IEnumerable<APP_OTHERCOLDETAILS>> GetAll();
        APP_OTHERCOLDETAILS Create(APP_OTHERCOLDETAILS app_othercoldetails);
        APP_OTHERCOLDETAILS Insert(APP_OTHERCOLDETAILS app_othercoldetails);
    }
}
