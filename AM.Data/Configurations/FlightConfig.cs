using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Data.Configurations
{
    internal class FlightConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            // Configuration de base de l'entité Flight
            builder.ToTable("Flights");
            builder.HasKey(f => f.FlightId);

            // Configuration de la relation one-to-many avec Plane
            builder.HasOne(f => f.MyPlane)
                   .WithMany(p => p.Flights)
                   .HasForeignKey(f => f.PlaneId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuration de la relation many-to-many avec Passenger
            builder.HasMany(f => f.Passengers)
                   .WithMany(p => p.Flightes)
                   .UsingEntity(j => j.ToTable("FlightPassenger"));
        }
    }
}