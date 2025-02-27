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
    internal class PlaneConfig : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            // Spécifier le nom de la table
            builder.ToTable("MyPlanes");

            // Définir la clé primaire
            builder.HasKey(p => p.PlaneId);

            // Configurer la propriété Capacity
            builder.Property(p => p.Capacity)
                   .HasColumnName("PlaneCapacity");
        }
    }
}