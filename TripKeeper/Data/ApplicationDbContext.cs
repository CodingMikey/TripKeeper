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

        public DbSet<Trip> Trip { get; set; }
        public DbSet<DotAudit> DotAudit { get; set; }
        public DbSet<EndRouteCheck> EndRouteCheck { get; set; }
        public DbSet<OperatorEquipment> OperatorEquipment { get; set; }
    }
}
