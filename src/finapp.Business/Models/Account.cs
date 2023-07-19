using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using finapp.Business.Interfaces;
using finnapp.Business.Models.Enums;

namespace finapp.Business.Models
{

    public class Account : Entity, IAccount
    {

        [ForeignKey("User")]
        public string UserId { get; set; }

        public AccountType AccountType { get; set; }//Enums/AccountTypes

        public string? AccountName { get; set; }

        public DateTime AccountDateRegister { get; set; }

        public decimal AccountOpeningBalance { get; set; }


        /* Relacionamento EF*/
        public IdentityUser User { get; set; }
    }
}