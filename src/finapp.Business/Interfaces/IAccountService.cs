using finapp.Business.Models;
using finnapp.Business.Models;

namespace finapp.Business.Interfaces
{
    public interface IAccountService : IDisposable
    {
        Task ToAdd(Accounts account);
        Task Update(Accounts account);
        Task Remove(Guid id);

    }
}