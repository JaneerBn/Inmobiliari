using Microsoft.EntityFrameworkCore;
using PropertyManagerContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagerContext.Models
{
    internal class PropertyManagerContext:DbContext
    {
        public DbSet<Models.Propiedad> Propiedades { get; set; }
        public DbSet<Models.Inquilino> Inquilinos { get; set; }
        public DbSet<Models.Contrato> Contratos { get; set; }
        public DbSet<Models.Pago> Pagos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=PropertyManager;Trusted_Connection=True;");
    }
}
}
