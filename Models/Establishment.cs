using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReservationsAPI.Models
{
    public class Establishment
    {
        public int ID { get; set; }
        [Required]
        [StringLength(64)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(256)]
        public string Direccion { get; set; }
        // Navigation Properties
        public ICollection<Evento> Eventos { get; set; }
    }
}