using MeuApp.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuApp.Data.Mappings
{

    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Address).IsRequired().HasMaxLength(80);
            builder.Property(u => u.AddressNumber).IsRequired().HasMaxLength(10);
            builder.Property(u => u.ZipCode).IsRequired().HasMaxLength(8);
            builder.Property(u => u.neighborhood).IsRequired().HasMaxLength(80);
        }
    }
}
