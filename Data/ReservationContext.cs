using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservationsAPI.Models;

    public class ReservationContext : DbContext
    {
        public ReservationContext (DbContextOptions<ReservationContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Establishment> Establishment { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
