namespace PropertyManagerContext.Models
{
    public class Propiedad
    {
        public int IdPropiedad { get; set; }
        public string Direccion { get; set; }
        public string TipoPropiedad { get; set; } // Apartamento, Casa, Comercial
        public int NumeroHabitaciones { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public bool Disponible { get; set; }

        public ICollection<Inquilino> Inquilinos { get; set; }
        public ICollection<Contrato> Contratos { get; set; }
    }
}
