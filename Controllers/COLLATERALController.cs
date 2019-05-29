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
    [Route("api/collateral")]
    [ApiController]
    public class COLLATERALController : ControllerBase
    {
        private ICOLLATERAL _collateral;

        public COLLATERALController(ICOLLATERAL collateral)
        {
            _collateral = collateral;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _collateral.GetAll();
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
        public IActionResult Create([FromBody]COLLATERAL collateral)
        {
            try
            {
                var data = _collateral.Create(collateral);
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
                    response_desc = "Gagal"
                });
            }
        }
    }
}
