using System.ComponentModel.DataAnnotations;

namespace ReservationsAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public string CodigoBarras { get; set; }
        [Required]
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        [Required]
        public bool PagaImpuesto { get; set; }
        // Foreign Key
        public int ProviderID { get; set; }
        // Navigation Properties
        public Provider Provider { get; set; }
    }
}