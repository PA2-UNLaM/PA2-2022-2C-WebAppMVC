using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PA2_2022_2C_WebAppMVC.Models;

namespace PA2_2022_2C_WebAppMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<PA2_2022_2C_WebAppMVC.Models.Provincias> Provincias { get; set; } = default!;

        public DbSet<PA2_2022_2C_WebAppMVC.Models.Localidades> Localidades { get; set; }
    }
}
