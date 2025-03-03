using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Data.Configurations
{
    public class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            // Configuration de FullName en tant que type détenu (Owned Entity)
            builder.OwnsOne(p => p.MyFullName, fullName =>
            {
                fullName.Property(f => f.FirstName)
                        .HasMaxLength(30)  // Longueur maximale de 30 caractères
                        .HasColumnName("Name"); // Nom de colonne "Name"

                fullName.Property(f => f.LastName)
                        .IsRequired(); // Obligatoire
            });
        }
    }
}
