using IMS.Interfaces;
using IMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace Context_FM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpPost("{customer}", Name = nameof(AddInventory))]
        public async Task<IActionResult> AddInventory([FromBody] Inventory inventory, Guid customer)
        {
            try
            {
                inventory = await _inventoryService.AddInventoryAsync(inventory, customer);

                return CreatedAtAction(nameof(GetById), new { id = inventory.Id, customer = customer}, inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/{customer}", Name = nameof(GetById))]
        public async Task<ActionResult<Inventory>> GetById(int id, Guid customer)
        {
            try
            {
                var inventory = await _inventoryService.GetInventoryByIdAsync(id, customer);

                return Ok(inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}/{stockDelta}/{customer}", Name = nameof(UpdateStockCount))]
        public async Task<ActionResult<int>> UpdateStockCount(int id, int stockDelta, Guid customer)
        {
            try
            {
                var currentStock = await _inventoryService.UpdateStockCountAsync(id, stockDelta, customer);

                if (currentStock == -999)
                {
                    throw new Exception("No inventory could be found with the provided id");
                }

                return Ok(currentStock);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{customer}", Name = nameof(UpdateStock))]
        public async Task<IActionResult> UpdateStock([FromBody] Inventory inventory, Guid customer)
        {
            try
            {
                await _inventoryService.UpdateInventoryAsync(inventory, customer);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
