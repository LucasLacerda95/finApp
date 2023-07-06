using finapp.Business.Models;
using finapp.Data.Mappings;
using finnapp.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace finapp.Data.Context{


    public class DataContext : DbContext{

        public DataContext(DbContextOptions<DataContext> options) : base(options){
            
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder){

 
            modelBuilder.ApplyConfiguration(new AccountMapping());

            modelBuilder.ApplyConfiguration(new CategoryMapping());
        }
    }
}