using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Services;

namespace ProjectGetPost.Controllers
{
    [Route("api/app_colmesin")]
    [ApiController]
    public class APP_COLMESINController : ControllerBase
    {
        private IAPP_COLMESIN _app_colmesin;

        public APP_COLMESINController(IAPP_COLMESIN app_colmesin)
        {
            _app_colmesin = app_colmesin;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            try
            {
                var data = await _app_colmesin.GetALL();
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
