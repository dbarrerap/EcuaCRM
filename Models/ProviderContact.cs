namespace ReservationsAPI.Models
{
    public class ProviderContact : Contacto
    {
        public int ProviderID { get; set; }

        public Provider Provider { get; set; }
    }
}