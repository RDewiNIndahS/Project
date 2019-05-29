using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectGetPost.Services;

namespace ProjectGetPost.Controllers
{
    [Route("api/rfdetailcollateral")]
    [ApiController]
    public class RFDETAILCOLLATERALController : ControllerBase
    {
        private IRFDETAILCOLLATERAL _rfdetailcollateral;

        public RFDETAILCOLLATERALController(IRFDETAILCOLLATERAL rfdetailcollateral)
        {
            _rfdetailcollateral = rfdetailcollateral;
        }

        [HttpGet("{CT_CODE}")]
        public async Task<IActionResult> GetByCode(string CT_CODE)
        {
            //return await this.userDataProvider.GetUsers();
            try
            {
                var data = await _rfdetailcollateral.GetByCode(CT_CODE);
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
