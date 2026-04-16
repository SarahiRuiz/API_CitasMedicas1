namespace API_Citas.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Apellido1 { get; set; }
        public required string Apellido2 { get; set; }
        public required string Edad { get; set; }
        public required string Correo { get; set; }
        public required string Contrasenia { get; set; }
    }
}
