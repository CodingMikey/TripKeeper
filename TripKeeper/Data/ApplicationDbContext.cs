using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TripKeeper.Models;

namespace TripKeeper.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<TripKeeper.Models.Trip> Trip { get; set; }
        public DbSet<TripKeeper.Models.DotAudit> DotAudit { get; set; }
        public DbSet<TripKeeper.Models.EndRouteCheck> EndRouteCheck { get; set; }
        public DbSet<TripKeeper.Models.OperatorEquipment> OperatorEquipment { get; set; }
    }
}
