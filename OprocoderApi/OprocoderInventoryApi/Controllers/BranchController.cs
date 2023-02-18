using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OprocoderInventoryApi.Inventory.Data.Entities;
using OprocoderInventoryApi.Inventory.Service;

namespace OprocoderInventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _service;
        public BranchController(IBranchService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetBranchList")]
        public async Task<IActionResult> GetBranchList()
        {
            try
            {
                var response = await _service.GetBranchList();
                if (response != null)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPost]
        [Route("CreateNewBranch")]
        public async Task<IActionResult> CreateBranch(Branch branch)
        {

            try
            {
                var response = await _service.CreateNewBranch(branch);
                if (response != null)
                {
                    return Ok(response);
                }
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
