using finapp.Business.Models;

namespace finapp.Business.Interfaces
{

    public interface IAccountRepository : IRepository<Account>
    {
        Task<IEnumerable<Account>> GetAccountsForUser(Guid UserId);

    }
}