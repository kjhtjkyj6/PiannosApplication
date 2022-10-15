using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PiannosApplication.Models;

namespace PiannosApplication.Data
{
    public class PiannosApplicationContext : DbContext
    {
        public PiannosApplicationContext(DbContextOptions<PiannosApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Piannos> Piannos { get; set; }
    }
}

