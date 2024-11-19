namespace PropertyManagerContext.Models
{
    public class Inquilino
    {
        public int IdInquilino { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public int? IdPropiedad { get; set; }
        public Propiedad Propiedad { get; set; }
        public ICollection<Contrato> Contratos { get; set; }
    }
}
