namespace proyecto.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Documento { get; set; }
        public string Genero { get; set; }
        public string Domicilio { get; set; }
        public string Mail { get; set; }
        public int? Telefono { get; set; }

        public Cliente()
        {
            Name = string.Empty; // o cualquier otro valor predeterminado
            Genero = string.Empty; // o cualquier otro valor predeterminado
            Domicilio = string.Empty; // o cualquier otro valor predeterminado
            Mail = string.Empty; // o cualquier otro valor predeterminado
        }
    }
}
