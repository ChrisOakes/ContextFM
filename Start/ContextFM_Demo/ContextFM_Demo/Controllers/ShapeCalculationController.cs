using ContextFM.Services;
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

        [HttpGet("/CircleArea/{radius}")]
        public async Task<IActionResult> CalculateCircleArea(decimal radius)
        {
            try
            {
                var area = ShapesDimensionsCalculationService.CalculateArea(radius);

                return Ok($"{area} cm squared");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/CirclePerimeter/{radius}")]
        public async Task<IActionResult> CalculateCirclePerimeter(decimal radius)
        {
            try
            {
                var perimeter = ShapesDimensionsCalculationService.CalculatePerimeter(radius);

                return Ok($"{perimeter} cm");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/TriangleArea/{breadth}/{height}")]
        public async Task<IActionResult> CalculateTriangleArea(decimal breadth, decimal height)
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

        [HttpGet("/TrianglePerimeter/{sideA}/{sideB}/{sideC}")]
        public async Task<IActionResult> CalculateTrianglePerimeter(decimal sideA, decimal sideB, decimal sideC)
        {
            try
            {
                var perimeter = ShapesDimensionsCalculationService.CalculatePerimeter(sideA, sideB, sideC);

                return Ok($"{perimeter} cm");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/SquareArea/{breadth}/{height}")]
        public async Task<IActionResult> CalculateSquareArea(decimal breadth, decimal height)
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

        [HttpGet("/SquarePerimeter/{breadth}/{height}")]
        public async Task<IActionResult> CalculateSquarePerimeter(decimal breadth, decimal height)
        {
            try
            {
                var perimeter = ShapesDimensionsCalculationService.CalculatePerimeter(breadth, height);

                return Ok($"{perimeter} cm");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
