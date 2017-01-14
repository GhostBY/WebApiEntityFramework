using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiEntityFramework.Models.Abstract;
using WebApiEntityFramework.Models.Entities;
using WebApiEntityFramework.Models.Concrete;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEntityFramework.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
       public IStudentRepository studentrepository { get; set; }
       public StudentController(IStudentRepository studentrepository)
       {
           this.studentrepository = studentrepository;
       }
        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return studentrepository.GetAll();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = studentrepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        [HttpPost]
        public IActionResult Add([FromBody] Student item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            studentrepository.Add(item);
            return CreatedAtRoute("GetStudent", new { Controller = "Student", id = item.Telephone }, item);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            studentrepository.Delete(id);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Student item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var contactObj = studentrepository.Find(id);
            if (contactObj == null)
            {
                return NotFound();
            }
            studentrepository.Update(item);
            return new NoContentResult();
        }
    }
}
