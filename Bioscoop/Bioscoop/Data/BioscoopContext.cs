using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;

namespace Bioscoop.Models
{
    public class BioscoopContext : DbContext
    {
        public BioscoopContext (DbContextOptions<BioscoopContext> options)
            : base(options)
        {
        }

        public DbSet<Bioscoop.Models.Genre> Genre { get; set; }

        public DbSet<Bioscoop.Models.Movie> Movie { get; set; }
    }
}
