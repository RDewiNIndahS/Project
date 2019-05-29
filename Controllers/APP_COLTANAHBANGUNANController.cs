using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Services;

namespace ProjectGetPost.Controllers
{
    [Route("api/appcoltanahbangunan")]
    [ApiController]
    public class APP_COLTANAHBANGUNANController : ControllerBase
    {
        private IAPP_COLTANAHBANGUNAN _app_coltanahbangunan;

        public APP_COLTANAHBANGUNANController(IAPP_COLTANAHBANGUNAN app_coltanahbangunan)
        {
            _app_coltanahbangunan = app_coltanahbangunan;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            try
            {
                var data = await _app_coltanahbangunan.GetALL();
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

    }
}
