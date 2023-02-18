using Microsoft.EntityFrameworkCore;
using OprocoderInventoryApi.Inventory.Data.Entities;

namespace OprocoderInventoryApi.Inventory.Data.Context
{
    public partial  class InventoryContext:DbContext
    {
        public InventoryContext()
        {
        }

        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Branch> Branch { get; set; }
    }
}
