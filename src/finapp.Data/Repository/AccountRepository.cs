using finapp.Business.Interfaces;
using finapp.Business.Models;
using finapp.Data.Context;

namespace finapp.Data.Repository
{


    public class AccountRepository : Repository<Account>, IAccountRepository
    {

        public AccountRepository(DataContext context) : base(context){}

        public async Task<IEnumerable<Account>> GetAccountsForUser(Guid userId)
        {
            return await Find(a => a.UserId == userId.ToString());
        }
    }
}