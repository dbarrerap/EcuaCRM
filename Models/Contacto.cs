using System.ComponentModel.DataAnnotations;

namespace ReservationsAPI.Models
{
    public class Contacto
    {
        public int ID { get; set; }
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}