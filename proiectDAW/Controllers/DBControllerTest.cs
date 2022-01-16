using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiectDAW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBControllerTest : ControllerBase
    {
        private readonly Context _Context;
        public DBControllerTest(Context Context)
        {
            _Context = Context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _Context.DataBaseModels.ToListAsync());
        }
    }
}
