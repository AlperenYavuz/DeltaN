using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeltaN.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeltaN.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=delta12.database.windows.net; initial catalog=delta12; persist security info=True; user id=delta12;password=Projectgroep12;");
        }
    }
}
