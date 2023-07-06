using finapp.Business.Models;

namespace finapp.Business.Interfaces
{

    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAccountsForUser(Guid UserId);

    }
}