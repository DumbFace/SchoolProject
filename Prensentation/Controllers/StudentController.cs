using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS.Data;
using CMS.Data.EFCore;
using CMS.Core.Domain;

namespace Prensentation.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {

        private SchoolContext context;
        public StudentController()
        {
            context = new SchoolContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var listStudent = context.Students.ToList();

            return Ok(listStudent);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetStudent([FromRoute] int id)
        {
            var student = context.Students.Where(x => x.Id == id).FirstOrDefault();
            return Ok(new { result = "OK", data = student });
        }


        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            context.Add(student);
            context.SaveChanges();
            return Ok("Saved!");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Student _student, [FromRoute] int id)
        {
            var student = context.Students.Where(x => x.Id == id).FirstOrDefault();
            student.Name = _student.Name;
            context.SaveChanges();
            return Ok("OK");
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var student = context.Students.Where(x => x.Id == id).FirstOrDefault();
            context.Students.Remove(student);
            context.SaveChanges();
            return Ok("OK");
        }
    }
}