using Bank.Data;
using Bank.Dtos;

namespace Bank.Repositories
{
    public class AccountRepo : IAccountRepo
    {
        private readonly appdbcontext _context;
        public AccountRepo(appdbcontext context)
        {
            _context = context;
        }

        public bool Post(AccountDtoPost accountDtoPost)
        {
            Models.Account account = new Models.Account
            {
                  AccountNumber = accountDtoPost.AccountNumber,
                   Balance = accountDtoPost.Balance,    
                    CustomerId = accountDtoPost.CustomerId,
                     
            };
            if(account != null)
            {
                _context.accounts.Add(account);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
