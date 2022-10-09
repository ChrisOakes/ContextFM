using IMS.Interfaces;
using IMS.Models;
using Microsoft.AspNetCore.Http;
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

        [HttpPost(Name = nameof(AddInventory))]
        public async Task<IActionResult> AddInventory([FromBody] Inventory inventory)
        {
            try
            {
                inventory = await _inventoryService.AddInventoryAsync(inventory);

                return CreatedAtAction(nameof(GetById), new { id = inventory.Id });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = nameof(GetById))]
        public async Task<ActionResult<Inventory>> GetById(int id)
        {
            try
            {
                var inventory = await _inventoryService.GetInventoryByIdAsync(id);

                return Ok(inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}/{stockDelta}", Name = nameof(UpdateStockCount))]
        public async Task<ActionResult<int>> UpdateStockCount(int id, int stockDelta)
        {
            try
            {
                var currentStock = await _inventoryService.UpdateStockCountAsync(id, stockDelta);

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

        [HttpPut("{id}/{stockDelta}", Name = nameof(UpdateStock))]
        public async Task<IActionResult> UpdateStock([FromBody] Inventory inventory)
        {
            try
            {
                await _inventoryService.UpdateInventoryAsync(inventory);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
