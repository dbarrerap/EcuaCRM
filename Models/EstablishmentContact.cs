namespace ReservationsAPI.Models
{
    public class EstablishmentContact : Contact
    {
        public int ContactID { get; set; }
        public int EstablishmentID { get; set; }

        public Contact contact { get; set; }
        public Establishment establishment { get; set; }
    }
}