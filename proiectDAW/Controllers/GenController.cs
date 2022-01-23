using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proiectDAW.Data;
using proiectDAW.Models.One_to_Many;
using proiectDAW.Servicii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenController : ControllerBase
    {
        private readonly IGenService _genService;
        public GenController(IGenService genService)
        {
            _genService = genService;
        }


        //get generic
        [HttpGet("getByIdGen/{id}")]
        public IActionResult GetById(string id)
        {
            var guid_id = new Guid(id);
            var result = _genService.getById(guid_id);
            return Ok(result);
        }

        //get custom
        [HttpGet("getByIdGenCustom/{id}")]
        public IActionResult getByIdCustom(string id)
        {
            var guid_id = new Guid(id);
            var result = _genService.getById(guid_id);
            return Ok(result);
        }

        [HttpGet("getByNumeGen")]
        public IActionResult getByTitleCustom(string title)
        {
            
            var result = _genService.getByTitleCustom(title);
            return Ok(result);
        }




    }
}
