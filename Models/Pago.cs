namespace PropertyManagerContext.Models
{
    public class Pago
    {
        public int IdPago { get; set; }

        public int IdContrato { get; set; }
        public Contrato Contrato { get; set; }

        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; } // Pendiente, Completado
    }
}
