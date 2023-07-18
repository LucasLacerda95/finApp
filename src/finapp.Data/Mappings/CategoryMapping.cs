using finnapp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace finapp.Data.Mappings
{

    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.CategoryType)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(c => c.CategoryRegisterDate)
                .IsRequired()
                .HasColumnType("datetime");


            builder.HasOne(u => u.User)
            .WithMany()
            .HasForeignKey(u => u.UserId)
            .IsRequired();


            builder.ToTable("Categories");


        }
    }
}