using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using studentdb.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace studentdb.Data
{
    class DbContext
    {
        public class StudentContext : DbContext
        {
            public StudentContext(DbContextOptions<StudentContext> options) : base(options)
            {
            }

            public DbSet<Student> Student { get; set; }
        }

    }
}
