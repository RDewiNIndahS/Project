using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Services;

namespace ProjectGetPost.Controllers
{
    [Route("api/rfcoltype")]
    [ApiController]
    public class RFCOLTYPEController : ControllerBase
    {
        private IRFCOLTYPE _rfcoltype;

        public RFCOLTYPEController(IRFCOLTYPE rfcoltype)
        {
            _rfcoltype = rfcoltype;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _rfcoltype.GetAll();
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
