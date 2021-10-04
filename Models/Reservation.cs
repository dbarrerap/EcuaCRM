namespace ReservationsAPI.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        // Foreign Keys
        public int EventoID { get; set; }
        public int ClienteID { get; set; }
        // Navigation Properties
        public Evento Evento { get; set; }
        public Cliente Cliente { get; set; }
    }
}