using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEntityFramework.Models.Entities;
namespace WebApiEntityFramework.Models.Abstract
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        void Add(Student student);
        Student Find(string key);
        void Delete(string id);
        void Update(Student student);
    }
}
