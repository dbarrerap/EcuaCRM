using System;

namespace ReservationsAPI.Models
{
    public class Evento
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Fecha { get; set; }
        public string Details { get; set; }
        public int EstablishmentID { get; set; }

        public Establishment establishment { get; set; }
    }
}