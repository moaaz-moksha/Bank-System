using Bank.Dtos;

namespace Bank.Repositories
{
    public interface IBranchRepo
    {
        public bool PostBranch(BranchDtoPost branchDtoPost);
        public List<BranchDtoGetAll> GettAll();
        public void Update(int id, BranchDtoUpdate dto);
        public bool Delete(int id); 
    }
}
