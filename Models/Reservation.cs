namespace ReservationsAPI.Models
{
    public class Reservation
    {
        public int ID { get; set; }

        public int UserID { get; set; }
        public int EventID { get; set; }

        public User user { get; set; }
        public Evento evento { get; set; }
    }
}