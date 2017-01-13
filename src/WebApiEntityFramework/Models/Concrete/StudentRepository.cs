using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEntityFramework.Models.Abstract;
using WebApiEntityFramework.Models.Entities;
using WebApiEntityFramework.Models.Context;

namespace WebApiEntityFramework.Models.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        static List<Student> StudentList = new List<Student>();
        StudentContext context = new StudentContext();
        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }
        public void Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var itemToRemove = StudentList.SingleOrDefault(r => r.Telephone == id);
            if (itemToRemove != null)
            {
                StudentList.Remove(itemToRemove);
            }
        }

        public Student Find(string key)
        {
            return StudentList.Where(e => e.Telephone.Equals(key)).SingleOrDefault();
        }

        public IEnumerable<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public void Update(Student student)
        {
            var itemToUpdate = StudentList.SingleOrDefault(r => r.Telephone ==student.Telephone);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = student.Name;
                itemToUpdate.Surname = student.Surname;
                itemToUpdate.Telephone = student.Telephone;
                itemToUpdate.Mail = student.Mail;
            }
        }
    }
}
