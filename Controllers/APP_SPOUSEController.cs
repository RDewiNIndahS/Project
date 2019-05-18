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
    [Route("api/app_spouse")]
    [ApiController]
    public class APP_SPOUSEController : ControllerBase
    {
        private IAPP_SPOUSE _app_spouseService;

        public APP_SPOUSEController(IAPP_SPOUSE app_spouseService)
        {
            _app_spouseService = app_spouseService;
        }
        // GET: api/APP_SPOUSE
        [HttpGet]
        public IActionResult GetByAll()
        {
            try
            {
                var data = _app_spouseService.GetByAll();
                return Ok(new
                {
                    response_code = "00",
                    response_desc = "Sukses",
                    data = data
                });
            }
            catch (Exception e)
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
