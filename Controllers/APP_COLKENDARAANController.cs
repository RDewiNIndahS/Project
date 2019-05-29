using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Services;

namespace ProjectGetPost.Controllers
{
    [Route("api/appcolkendaraan")]
    [ApiController]
    public class APP_COLKENDARAANController : ControllerBase
    {
        private IAPP_COLKENDARAAN _app_colkendaraan;

        public APP_COLKENDARAANController(IAPP_COLKENDARAAN app_colkendaraan)
        {
            _app_colkendaraan = app_colkendaraan;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            try
            {
                var data = await _app_colkendaraan.GetALL();
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
