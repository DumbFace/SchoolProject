using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Data.EFCore;
using CMS.Data.Service.CategoryService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Prensentation.Areas.cp.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly ICategoryService _service;
        private KhangDB context;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(new { result = "OK", data = _service.GetById(id) });
        }


        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            _service.Insert(category);
            _service.Save();
            return Ok("Saved!");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Category category, [FromRoute] int id)
        {
            _service.Update(category);
            _service.Save();
            return Ok("OK");
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _service.Delete(id);
            _service.Save();
            return Ok("OK");
        }
    }
}