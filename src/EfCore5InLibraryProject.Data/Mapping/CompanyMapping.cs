using EfCore5InLibraryProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCore5InLibraryProject.Data.Mapping
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();

            builder.Property(x => x.Name).HasColumnType("varchar(60)");
            builder.Property(x => x.Number).HasColumnType("varchar(60)");

            builder.HasMany(x => x.Customers)
                .WithOne(x => x.Company)
                .HasForeignKey("CompanyId")
                .OnDelete(DeleteBehavior.SetNull);

            builder.ToTable("Companies");
        }
    }
}
