using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Duozin.Models;

namespace Duozin.Data.Configurations
{
    public class MidConfiguration : IEntityTypeConfiguration<MidModel>
    {
        public void Configure(EntityTypeBuilder<MidModel> builder)
        {
            builder.ToTable("Mids");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Name).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(m => m.Age).HasColumnType("INT").IsRequired();
            builder.Property(m => m.MartialArts).HasColumnType("INT").IsRequired();
            builder.Property(m => m.Fights).HasColumnType("INT").IsRequired();
            builder.Property(m => m.Defeats).HasColumnType("INT").IsRequired();
            builder.Property(m => m.Victories).HasColumnType("INT").IsRequired();
        }
    }

    
}