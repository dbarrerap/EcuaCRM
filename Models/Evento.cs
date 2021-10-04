using System;
using System.ComponentModel.DataAnnotations;

namespace ReservationsAPI.Models
{
    public class Evento
    {
        public int ID { get; set; }
        [Required]
        [StringLength(96)]
        public string Nombre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        // Foreign Key
        [Required]
        public int EstablishmentID { get; set; }
        // Navigation Properties
        public Establishment Establishment { get; set; }
    }
}