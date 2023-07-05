using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using finnapp.Business.Models.Enums;
using Microsoft.AspNetCore.Identity;



namespace finapp.Business.Models{

    public class Accounts{
        [Key]
        public Guid AccountId { get; set; }

        public AccountType AccountType { get; set; }//Enums/AccountTypes

        public string? AccountName { get; set; }

        public DateTime AccountDateRegister { get; set; }

        public decimal AccountOpeningBalance  { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        

        /* Relacionamento EF*/
        public IdentityUser? User { get; set; }
    }
}