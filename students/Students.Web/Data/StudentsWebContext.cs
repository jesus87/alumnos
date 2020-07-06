using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Students.Core.Models;

namespace Students.Web.Models
{
    public class StudentsWebContext : DbContext
    {
        public StudentsWebContext (DbContextOptions<StudentsWebContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Order> Order { get; set; }
    }
}
