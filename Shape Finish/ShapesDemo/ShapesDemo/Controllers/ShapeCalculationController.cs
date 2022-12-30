using Microsoft.AspNetCore.Mvc;
using ShapesDemo.Common;
using ShapesDemo.DTOs;
using ShapesDemo.Interfaces;
using ShapesDemo.Services;

namespace ShapesDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeCalculationController : ControllerBase
    {
        //public ShapesDimensionsCalculationService ShapesDimensionsCalculationService { get; set; }

        private readonly IShapeFactoryService _shapeFactoryService;

        public ShapeCalculationController(IShapeFactoryService shapeFactoryService)
        {
            //ShapesDimensionsCalculationService = new ShapesDimensionsCalculationService();
            _shapeFactoryService = shapeFactoryService;
        }

        [HttpPost($"/{nameof(CalculateArea)}")]
        public async Task<IActionResult> CalculateArea([FromBody] ShapesDto shapesDto, ShapeEnum shapeEnum)
        {
            try
            {
                var shapeService = _shapeFactoryService.CreateShapeCalculationService(shapeEnum);

                var area = shapeService.CalculateArea(shapesDto);

                return Ok($"The area of the {shapeEnum} is {area} cm squared");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost($"/{nameof(CalculatePerimeter)}")]
        public async Task<IActionResult> CalculatePerimeter([FromBody] ShapesDto shapesDto, ShapeEnum shapeEnum)
        {
            try
            {
                var shapeService = _shapeFactoryService.CreateShapeCalculationService(shapeEnum);

                var perimeter = shapeService.CalculatePerimeter(shapesDto);

                return Ok($"The perimeter of the {shapeEnum} is {perimeter} cm");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpGet("/AreaCircle/{radius}")]
        //public async Task<IActionResult> CalculateAreaCircle(decimal radius)
        //{
        //    try
        //    {
        //        var area = ShapesDimensionsCalculationService.CalculateAreaCircle(radius);

        //        return Ok($"{area} cm squared");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/PerimeterCircle/{radius}")]
        //public async Task<IActionResult> CalculatePerimeterCircle(decimal radius)
        //{
        //    try
        //    {
        //        var perimeter = ShapesDimensionsCalculationService.CalculatePerimeterCircle(radius);

        //        return Ok($"{perimeter} cm");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/AreaTriangle/{breadth}/{height}")]
        //public async Task<IActionResult> CalculateAreaTriangle(decimal breadth, decimal height)
        //{
        //    try
        //    {
        //        var area = ShapesDimensionsCalculationService.CalculateAreaTriangle(breadth, height);

        //        return Ok($"{area} cm squared");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/PerimeterTriangle/{sideA}/{sideB}/{sideC}")]
        //public async Task<IActionResult> CalculatePerimeterTriangle(decimal sideA, decimal sideB, decimal sideC)
        //{
        //    try
        //    {
        //        var perimeter = ShapesDimensionsCalculationService.CalculatePerimeterTriangle(sideA, sideB, sideC);

        //        return Ok($"{perimeter} cm");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/AreaSquare/{length}")]
        //public async Task<IActionResult> CalculateAreaSquare(decimal length)
        //{
        //    try
        //    {
        //        var area = ShapesDimensionsCalculationService.CalculateAreaSquare(length);

        //        return Ok($"{area} cm squared");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/PerimeterSquare/{length}")]
        //public async Task<IActionResult> CalculatePerimeterSquare(decimal length)
        //{
        //    try
        //    {
        //        var perimeter = ShapesDimensionsCalculationService.CalculatePerimeterSquare(length);

        //        return Ok($"{perimeter} cm");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
