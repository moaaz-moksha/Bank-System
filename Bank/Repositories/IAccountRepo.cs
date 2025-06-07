using Bank.Dtos;

namespace Bank.Repositories
{
    public interface IAccountRepo
    {
        public bool Post(AccountDtoPost accountDtoPost);
    }
}
