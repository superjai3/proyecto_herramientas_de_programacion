using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyecto.Models;

namespace proyecto.Data
{
    public class VariosPlatosContext : DbContext
    {
        public VariosPlatosContext (DbContextOptions<VariosPlatosContext> options)
            : base(options)
        { 
        }

        public DbSet<proyecto.Models.Plato> Plato { get; set; } = default!;
    }
}
