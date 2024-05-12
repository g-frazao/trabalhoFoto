using trabalhoFoto.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using trabalhoFoto.Controllers;

namespace trabalhoFoto.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }
        public DbSet<CadastroDeUsuarios> trabalhoFotos { get; set; }
    }
}