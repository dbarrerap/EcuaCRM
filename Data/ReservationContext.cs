using Microsoft.EntityFrameworkCore;
using ReservationsAPI.Models;

namespace ReservationsAPI.Data
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EstablishmentContact> EstablishmentContacts { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<User>().ToTable("User");
            model.Entity<Establishment>().ToTable("Establishment");
            model.Entity<Contact>().ToTable("Contact");
            model.Entity<EstablishmentContact>().ToTable("EstablishmentContact");
            model.Entity<Evento>().ToTable("Evento");
            model.Entity<Reservation>().ToTable("Reservation");
        }
    }
}