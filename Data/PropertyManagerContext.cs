using Microsoft.EntityFrameworkCore;
using PropertyManagerContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagerContext.Models
{

/**/
using Microsoft.AspNetCore.Identity;
using PropertyManager.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.Run();

/**/

    var builder = WebApplication.CreateBuilder(args);

// Agregar contexto de base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configurar Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = true;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseAuthentication();  // Activar autenticación
app.UseAuthorization();   // Activar autorización

app.MapRazorPages();
app.Run();


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
