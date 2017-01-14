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

        public void Delete(int id)
        {
            var itemToRemove = context.Students.SingleOrDefault(r => r.StudentID == id);
            if (itemToRemove != null)
            {
                context.Remove(itemToRemove);
                context.SaveChanges();
            }
        }

        public Student Find(int id)
        {
            var s1 = context.Students.Where(e => e.StudentID == id).SingleOrDefault();
            return s1;
        }

        public IEnumerable<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public void Update(Student student)
        {
            var itemToUpdate = context.Students.SingleOrDefault(r => r.StudentID ==student.StudentID);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = student.Name;
                itemToUpdate.Surname = student.Surname;
                itemToUpdate.Telephone = student.Telephone;
                itemToUpdate.Mail = student.Mail;
                context.SaveChanges();
            }
        }
    }
}
