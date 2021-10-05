using System.ComponentModel.DataAnnotations;

namespace ReservationsAPI.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        [Required]
        [StringLength(64)]
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(64)]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}