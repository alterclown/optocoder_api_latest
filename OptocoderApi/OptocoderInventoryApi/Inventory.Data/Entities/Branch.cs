using Microsoft.EntityFrameworkCore;
using OptocoderInventoryApi.Inventory.Data.Utilities;
using System.ComponentModel.DataAnnotations;

namespace OprocoderInventoryApi.Inventory.Data.Entities
{
    public partial class Branch: AuditableEntity
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchDescription { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }
}
