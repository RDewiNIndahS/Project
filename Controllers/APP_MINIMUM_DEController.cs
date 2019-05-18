using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Models;
using ProjectGetPost.Services;

namespace ProjectGetPost.Controllers
{
    [Route("api/APP_MINIMUM_DE")]
    [ApiController]
    public class APP_MINIMUM_DEController : ControllerBase
    {
        private IAPP_MINIMUM_DE _app_minimum_deService;

        public APP_MINIMUM_DEController(IAPP_MINIMUM_DE app_minimum_deService)
        {
            _app_minimum_deService = app_minimum_deService;
        }

        // GET: api/APP_MINIMUM_DE
        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _app_minimum_deService.GetAll();
            return Ok(new
            {
                data = data
            });
        }

        [HttpGet]
        [Route("{AP_REGNO}")]
        public IActionResult GetById(string AP_REGNO)
        {
            try
            {
                var data = _app_minimum_deService.GetById(AP_REGNO);
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
        public IActionResult Create(APP_MINIMUM_DE app_minimum_de, string spousename, string IDNUMBER_SPOUSE)
        {
            try
            {
                var data = _app_minimum_deService.Create(app_minimum_de, spousename, IDNUMBER_SPOUSE);
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
                    message = e.ToString(),
                    response_code = "99",
                    response_desc = "Gagal",
                });
            }
        }

    }
}
