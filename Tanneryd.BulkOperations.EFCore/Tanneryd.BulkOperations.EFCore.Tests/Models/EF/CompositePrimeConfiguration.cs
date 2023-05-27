// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // CompositePrime
    public class CompositePrimeConfiguration : IEntityTypeConfiguration<CompositePrime>
    {
        public void Configure(EntityTypeBuilder<CompositePrime> builder)
        {
            builder.ToTable("CompositePrime", "dbo");
            builder.HasKey(x => new { x.CompositeId, x.PrimeId }).HasName("PK_dbo.CompositePrime").IsClustered();

            builder.Property(x => x.CompositeId).HasColumnName(@"CompositeId").HasColumnType("bigint").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PrimeId).HasColumnName(@"PrimeId").HasColumnType("bigint").IsRequired().ValueGeneratedNever();

            // Foreign keys
            builder.HasOne(a => a.Composite).WithMany(b => b.CompositePrimes).HasForeignKey(c => c.CompositeId).HasConstraintName("FK_dbo.CompositePrime_dbo.Composite_CompositeId");
            builder.HasOne(a => a.Prime).WithMany(b => b.CompositePrimes).HasForeignKey(c => c.PrimeId).HasConstraintName("FK_dbo.CompositePrime_dbo.Prime_PrimeId");

            builder.HasIndex(x => x.CompositeId).HasName("IX_CompositeId");
            builder.HasIndex(x => x.PrimeId).HasName("IX_PrimeId");
        }
    }

}
// </auto-generated>
