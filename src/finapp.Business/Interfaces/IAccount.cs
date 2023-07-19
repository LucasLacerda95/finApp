using finnapp.Business.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace finapp.Business.Interfaces{

    public interface IAccount{

        public string UserId { get; set; }

        public AccountType AccountType { get; set; }
        public string AccountName { get; set; }
        public DateTime AccountDateRegister { get; set; }
        public decimal AccountOpeningBalance { get; set; }

        public IdentityUser User { get; set; }

    }
}