namespace ReservationsAPI.Models
{
    public class EstablishmentContact : Contacto
    {
        public int EstablishmentID { get; set; }

        public Establishment Establishment { get; set; }
    }
}