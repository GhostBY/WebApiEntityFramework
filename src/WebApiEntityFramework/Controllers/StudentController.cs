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
    }
}
