using finnapp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace finapp.Data.Mappings
{

    public class CategoryMapping : IEntityTypeConfiguration<Categories>
    {

        public void Configure(EntityTypeBuilder<Categories> builder)
        {

            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.CategoryType)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(c => c.CategoryRegisterDate)
                .IsRequired()
                .HasColumnType("datetime2");


            builder.HasOne(u => u.User)
            .WithMany()
            .HasForeignKey(u => u.UserId)
            .IsRequired();


            builder.ToTable("Categories");


        }
    }
}