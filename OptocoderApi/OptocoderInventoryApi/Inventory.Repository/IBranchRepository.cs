using Microsoft.EntityFrameworkCore;
using OprocoderInventoryApi.Inventory.Data.Context;
using OprocoderInventoryApi.Inventory.Data.Entities;
using System.Net.NetworkInformation;

namespace OprocoderInventoryApi.Inventory.Repository
{
    public interface IBranchRepository
    {
        Task<ICollection<Branch>> GetBranchList();
        Task<Branch> GetBranch(int id);
        Task<int> GetBranchCount();
        Task<Branch> CreateNewBranch(Branch branch);
    }

    public class BranchRepository : IBranchRepository
    {
        private readonly InventoryContext _context;

        public BranchRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Branch> CreateNewBranch(Branch branch)
        {
            try
            {
                _context.Branch.Add(branch);
                await _context.SaveChangesAsync();
                return branch;
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
       
                var pagedData = await _context.Branch.ToListAsync();
                return pagedData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
