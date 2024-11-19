namespace PropertyManager.Models
{
    public class Contrato
    {
        public int IdContrato { get; set; }

        public int IdPropiedad { get; set; }
        public Propiedad Propiedad { get; set; }

        public int IdInquilino { get; set; }
        public Inquilino Inquilino { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Deposito { get; set; }
        public string Terminos { get; set; }

        public ICollection<Pago> Pagos { get; set; }
    }
}
