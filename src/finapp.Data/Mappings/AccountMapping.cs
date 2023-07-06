using finapp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace finapp.Data.Mappings
{


    public class AccountMapping : IEntityTypeConfiguration<Account>{

        public void Configure(EntityTypeBuilder<Account> builder) {

            builder.HasKey(a => a.Id);

            builder.Property(a => a.AccountType)
                .IsRequired()
                .HasColumnType("integer");

            builder.Property(a => a.AccountName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.AccountDateRegister)
                .IsRequired()
                .HasColumnType("datetime2");

            builder.Property(a => a.AccountOpeningBalance)
                .IsRequired()
                .HasColumnType("decimal(7,2)");


            builder.HasOne(u => u.User)
            .WithMany()
            .HasForeignKey(u => u.UserId)
            .IsRequired();

            builder.ToTable("Accounts");
             
                 
        }
    }
}