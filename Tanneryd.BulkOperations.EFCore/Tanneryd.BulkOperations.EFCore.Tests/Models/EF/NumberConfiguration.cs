// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Number
    public class NumberConfiguration : IEntityTypeConfiguration<Number>
    {
        public void Configure(EntityTypeBuilder<Number> builder)
        {
            builder.ToTable("Number", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_dbo.Number").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Value).HasColumnName(@"Value").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.ParityId).HasColumnName(@"ParityId").HasColumnType("int").IsRequired();
            builder.Property(x => x.PrimeId).HasColumnName(@"PrimeId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.CompositeId).HasColumnName(@"CompositeId").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.UpdatedAt).HasColumnName(@"UpdatedAt").HasColumnType("datetime").IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar(max)").IsRequired(false);

            // Foreign keys
            builder.HasOne(a => a.Parity).WithMany(b => b.Numbers).HasForeignKey(c => c.ParityId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_dbo.Number_dbo.Parity_ParityId");

            builder.HasIndex(x => x.ParityId).HasName("IX_ParityId");
        }
    }

}
// </auto-generated>