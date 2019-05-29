using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Services;

namespace ProjectGetPost.Controllers
{
    [Route("api/appcolsuratberharga")]
    [ApiController]
    public class APP_COLSURATBERHARGAController : ControllerBase
    {
        private IAPP_COLSURATBERHARGA _app_colsuratberharga;

        public APP_COLSURATBERHARGAController(IAPP_COLSURATBERHARGA app_colsuratberharga)
        {
            _app_colsuratberharga = app_colsuratberharga;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            try
            {
                var data = await _app_colsuratberharga.GetALL();
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
