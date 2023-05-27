// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // EmptyTable
    public class EmptyTableConfiguration : IEntityTypeConfiguration<EmptyTable>
    {
        public void Configure(EntityTypeBuilder<EmptyTable> builder)
        {
            builder.ToTable("EmptyTable", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_dbo.EmptyTable").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }

}
// </auto-generated>
