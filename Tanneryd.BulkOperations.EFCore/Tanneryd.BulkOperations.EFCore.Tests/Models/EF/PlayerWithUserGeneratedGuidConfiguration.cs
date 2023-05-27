// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // PlayerWithUserGeneratedGuid
    public class PlayerWithUserGeneratedGuidConfiguration : IEntityTypeConfiguration<PlayerWithUserGeneratedGuid>
    {
        public void Configure(EntityTypeBuilder<PlayerWithUserGeneratedGuid> builder)
        {
            builder.ToTable("PlayerWithUserGeneratedGuid", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_dbo.PlayerWithUserGeneratedGuid").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Firstname).HasColumnName(@"Firstname").HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.Lastname).HasColumnName(@"Lastname").HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.TeamId).HasColumnName(@"TeamId").HasColumnType("uniqueidentifier").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.TeamWithUserGeneratedGuid).WithMany(b => b.PlayerWithUserGeneratedGuids).HasForeignKey(c => c.TeamId).HasConstraintName("FK_dbo.PlayerWithUserGeneratedGuid_dbo.TeamWithUserGeneratedGuid_TeamId");

            builder.HasIndex(x => x.TeamId).HasName("IX_TeamId");
        }
    }

}
// </auto-generated>
