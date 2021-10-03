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

        public DbSet<ReservationsAPI.Models.User> User { get; set; }
    }
