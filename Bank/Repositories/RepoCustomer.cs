using Bank.Data;
using Bank.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Bank.Repositories
{
    public class RepoCustomer : IRepoCustomer
    {
        private readonly appdbcontext _context;
        public RepoCustomer(appdbcontext context)
        {
            _context = context;
        }
        public bool Add(CustomerDto customerDto)
        {
            Models.Customer add = new Models.Customer
            {
                 BankCard = new Models.BankCard
                 {
                      CardNumber = customerDto.BankCardDto.CardNumber,
                       ExpiryDate = customerDto.BankCardDto.ExpiryDate,
                        
                 },
                 Account = customerDto.accountDtos.Select(y => new Models.Account
                 {
                      AccountNumber = y.AccountNumber,
                       Balance = y.Balance,
                        
                 }).ToList(),
                 Name = customerDto.Name,
                  EmailAddress = customerDto.EmailAddress,
                   PhoneNumber = customerDto.PhoneNumber,
                    Branches = customerDto.branchDtos.Select(x => new Models.Branch
                    {
                         Name = x.Name,
                          Location = x.Location,
                           
                    }).ToList(),
            };
            if(add != null)
            {
                _context.customer.Add(add);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public CustomerDtoGetById GetById(int id)
        {
            var res = _context.customer.Include(u=> u.BankCard).Include(p=> p.Branches).FirstOrDefault(x => x.Id == id);
            if(res != null)
            {
                CustomerDtoGetById add = new CustomerDtoGetById
                {
                     
                     branchDtos = res.Branches.Select(x => new BranchDto
                     {
                          
                          Location = x.Location,
                           Name = x.Name,
                     }).ToList(),
                     Name = res.Name,
                      EmailAddress = res.EmailAddress,
                       PhoneNumber = res.PhoneNumber,
                        BankCardDto = new BankCardDto
                        {
                             
                             CardNumber = res.BankCard.CardNumber,
                              ExpiryDate = res.BankCard.ExpiryDate,   
                        }
                };
                return add;
            }
            return null;
        }
    }
}
