using ShapesFM.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContextFM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeCalculationController : ControllerBase
    {
        public ShapesDimensionsCalculationService ShapesDimensionsCalculationService { get; set; }

        public ShapeCalculationController()
        {
            ShapesDimensionsCalculationService = new ShapesDimensionsCalculationService();
        }

        [HttpGet("/AreaCircle/{radius}")]
        public async Task<IActionResult> CalculateAreaCircle(decimal radius)
        {
            try
            {
                var area = ShapesDimensionsCalculationService.CalculateAreaCircle(radius);

                return Ok($"{area} cm squared");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/PerimeterCircle/{radius}")]
        public async Task<IActionResult> CalculatePerimeterCircle(decimal radius)
        {
            try
            {
                var perimeter = ShapesDimensionsCalculationService.CalculatePerimeterCircle(radius);

                return Ok($"{perimeter} cm");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/AreaTriangle/{breadth}/{height}")]
        public async Task<IActionResult> CalculateAreaTriangle(decimal breadth, decimal height)
        {
            try
            {
                var area = ShapesDimensionsCalculationService.CalculateAreaTriangle(breadth, height);

                return Ok($"{area} cm squared");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/PerimeterTriangle/{sideA}/{sideB}/{sideC}")]
        public async Task<IActionResult> CalculatePerimeterTriangle(decimal sideA, decimal sideB, decimal sideC)
        {
            try
            {
                var perimeter = ShapesDimensionsCalculationService.CalculatePerimeterTriangle(sideA, sideB, sideC);

                return Ok($"{perimeter} cm");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/AreaSquare/{length}")]
        public async Task<IActionResult> CalculateAreaSquare(decimal length)
        {
            try
            {
                var area = ShapesDimensionsCalculationService.CalculateAreaSquare(length);

                return Ok($"{area} cm squared");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/PerimeterSquare/{length}")]
        public async Task<IActionResult> CalculatePerimeterSquare(decimal length)
        {
            try
            {
                var perimeter = ShapesDimensionsCalculationService.CalculatePerimeterSquare(length);

                return Ok($"{perimeter} cm");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
