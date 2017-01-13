using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEntityFramework.Models.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
    }
}
