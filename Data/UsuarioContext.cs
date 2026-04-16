using API_Citas.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Citas.Data
{
    public class UsuarioContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
