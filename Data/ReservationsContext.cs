using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservationsAPI.Models;

    public class ReservationsContext : DbContext
    {
        public ReservationsContext (DbContextOptions<ReservationsContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Establishment> Establishment { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<EstablishmentContact> EstablishmentContact { get; set; }
        public DbSet<ProviderContact> ProviderContact { get; set; }
}
