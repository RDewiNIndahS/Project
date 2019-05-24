using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Services;
using ProjectGetPost.Models;

namespace ProjectGetPost.Controllers
{
    [Route("api/app_othercoldetails")]
    [ApiController]
    public class APP_OTHERCOLSDETAILSController : ControllerBase
    {
        private IAPP_OTHERCOLDETAILS _app_othercoldetails;

        public APP_OTHERCOLSDETAILSController(IAPP_OTHERCOLDETAILS app_othercoldetails)
        {
            _app_othercoldetails = app_othercoldetails;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //return await this.userDataProvider.GetUsers();
            try
            {
                var data = await _app_othercoldetails.GetAll();
                return Ok(new
                {
                    response_code = "00",
                    response_desc = "Sukses",
                    data = data
                });
            }catch(Exception e)
            {
                return BadRequest(new
                {
                    message = e.ToString(),
                    response_code = "99",
                    response_desc = "Gagal",
                });
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody]APP_OTHERCOLDETAILS app_othercoldetails)
        {
            try
            {
                var data = _app_othercoldetails.Create(app_othercoldetails);
                return Ok(new
                {
                    response_code = "00",
                    response_desc = "Sukses",
                    AP_REGNO = data.AP_REGNO
                });
            }catch(Exception e)
            {
                return BadRequest(new
                {
                    response_code = "99",
                    response_desc = "Gagal"
                });
            }
        }

        [HttpPost]
        [Route("coba")]
        public IActionResult Insert([FromBody]APP_OTHERCOLDETAILS app_othercoldetails)
        {
            var data =_app_othercoldetails.Insert(app_othercoldetails);
            return Ok(new
            {
                response_code = "00",
                response_desc = "Sukses",
                AP_REGNO = data.AP_REGNO
            });
        }
    }
}
