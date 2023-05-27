// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tanneryd.BulkOperations.EFCore.Tests
{
    // Post
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_dbo.Post").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.BlogId).HasColumnName(@"BlogId").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.Text).HasColumnName(@"Text").HasColumnType("nvarchar(max)").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Blog).WithMany(b => b.Posts).HasForeignKey(c => c.BlogId).HasConstraintName("FK_dbo.Post_dbo.Blog_BlogId");

            builder.HasIndex(x => x.BlogId).HasName("IX_BlogId");
            
            // builder
            //     .HasMany(p => p.Visitors)
            //     .WithMany(p => p.Posts)
            //     .UsingEntity(j => j.ToTable("VisitorPosts"));
        }
    }

}
// </auto-generated>
