using finapp.Business.Interfaces;
using finapp.Business.Models;

namespace finapp.Business.Services
{

    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository){
            _accountRepository = accountRepository;
        }

        public async Task Add(Account account)
        {
            await _accountRepository.Add(account);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task ToAdd(Account account)
        {
            throw new NotImplementedException();
        }

        public Task Update(Account account)
        {
            throw new NotImplementedException();
        }
    }
}