namespace ReservationsAPI.Models
{
    public enum Type {
        RESTAURANT, 
        BAR, 
        DISCO
    }
    public class Establishment {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Type EstablishmentType { get; set; }
    }
}