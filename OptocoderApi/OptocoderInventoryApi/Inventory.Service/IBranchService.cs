using OprocoderInventoryApi.Inventory.Data.Entities;
using OprocoderInventoryApi.Inventory.Repository;

namespace OprocoderInventoryApi.Inventory.Service
{
    public interface IBranchService
    {
        Task<ICollection<Branch>> GetBranchList();
        Task<Branch> GetBranch(int id);
        Task<int> GetBranchCount();
        Task<Branch> CreateNewBranch(Branch branch);
    }
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _repository;
        public BranchService(IBranchRepository repository)
        {
            _repository = repository;
        }

        public async Task<Branch> CreateNewBranch(Branch branch)
        {
            try
            {
                var res = await _repository.CreateNewBranch(branch);
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<Branch> GetBranch(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetBranchCount()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Branch>> GetBranchList()
        {
            try
            {
                var res = await _repository.GetBranchList();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
