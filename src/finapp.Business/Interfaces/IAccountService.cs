using finapp.Business.Models;

namespace finapp.Business.Interfaces
{
    public interface IAccountService 
    {
        Task Add(Account account);
        Task Update(Account account);
        Task Remove(Guid id);

    }
}