using Bank.Data;
using Bank.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Bank.Repositories
{
    public class BranchRepo : IBranchRepo
    {
        private readonly appdbcontext _context;
        public BranchRepo(appdbcontext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
           var res = _context.branch.FirstOrDefault(u => u.Id == id);
            if(res != null)
            {
                _context.branch.Remove(res);
                _context.SaveChanges();
                return true;
            }
            return false;   
        }

        public List<BranchDtoGetAll> GettAll()
        {
            var res = _context.branch.Select(u => new BranchDtoGetAll
            {
                 Location = u.Location,
                  Name = u.Name,
                   customerDtoGetAlls = u.customers.Select(i => new CustomerDtoGetAll
                   {
                        Name = i.Name,
                         EmailAddress = i.EmailAddress,
                          PhoneNumber = i.PhoneNumber,
                          accountDtos = i.Account.Select(p => new AccountDto
                          {
                               AccountNumber = p.AccountNumber,
                                 Balance = p.Balance,
                                  
                          }).ToList(),
                   }).ToList(),
            }).ToList();
            return res;
        }

        public bool PostBranch(BranchDtoPost branchDtoPost)
        {
            Models.Branch add = new Models.Branch
            {
                 Location = branchDtoPost.Location, 
                  Name = branchDtoPost.Name,
                   customers = branchDtoPost.customerDtoPPPPPs.Select(u => new Models.Customer
                   {
                        Name = u.Name,
                         PhoneNumber = u.PhoneNumber,
                          EmailAddress = u.EmailAddress,
                           
                   }).ToList(),
            };
            if(add != null)
            {
                _context.branch.Add(add);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

       public void Update(int id, BranchDtoUpdate dto)
{
    var branch = _context.branch
        .Include(b => b.customers)
        .FirstOrDefault(b => b.Id == id);

    if (branch == null)
        throw new Exception("not found");
  
    branch.Name = dto.Name;
    branch.Location = dto.Location;

    if (dto.CustomerIds != null)
    {
        var customers = _context.customer
            .Where(c => dto.CustomerIds.Contains(c.Id))
            .ToList();
        if (customers.Count != dto.CustomerIds.Count)
            throw new Exception("not found");

        branch.customers = customers;
    }

    _context.SaveChanges();
    
}
    }
}

