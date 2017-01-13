using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiEntityFramework.Models.Entities;

namespace WebApiEntityFramework.Models.Context
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            :base(options) { }
        public StudentContext() { }
        public DbSet<Student> Students { get; set; }
    }
}
