using API_Citas.Entities;
using Microsoft.EntityFrameworkCore;
using static API_Citas.Entities.Usuario;

namespace API_Citas.Data
{
    public class DbInitializer
    {
        public static void InitDb(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<UsuarioContext>()
                ?? throw new InvalidOperationException("Failed to retrieve store context");
            SeedData(context);
        }
        //adding dummy data to the database
        private static void SeedData(UsuarioContext context)
        {
            //restart the database and apply any pending migrations
            context.Database.Migrate();
            if (context.Usuarios.Any()) return;

            var usuarios = new List<Usuario>
            {
                new Usuario
                {
                    Name = "Ale",
                    Apellido1 = "Sand",
                    Apellido2 = "Flores",
                    Edad = "23",
                    Correo = "ale@test.com",
                    Contrasenia = "test1"
                    
                },
                new Usuario
                {
                    Name = "Sara",
                    Apellido1 = "Ruiz",
                    Apellido2 = "P",
                    Edad = "23",
                    Correo = "sara@test.com",
                    Contrasenia = "test2"
                },
                // Add more products as needed
            };
            context.Usuarios.AddRange(usuarios);
            context.SaveChanges();
        }
    }
}
