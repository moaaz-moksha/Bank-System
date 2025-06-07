using Bank.Dtos;

namespace Bank.Repositories
{
    public interface IRepoCustomer
    {
        public bool Add(CustomerDto customerDto);
        public CustomerDtoGetById GetById(int id);
    }
}
