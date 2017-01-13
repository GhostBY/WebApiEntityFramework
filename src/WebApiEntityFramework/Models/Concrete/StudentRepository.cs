using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEntityFramework.Models.Abstract;
using WebApiEntityFramework.Models.Entities;

namespace WebApiEntityFramework.Models.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Student Find(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
