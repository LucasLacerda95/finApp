using finapp.Business.Models;
using finnapp.Business.Models;

namespace finapp.Business.Interfaces
{
    public interface IAccountService : IDisposable
    {
        Task Add(Account account);
        Task Update(Account account);
        Task Remove(Guid id);

    }
}