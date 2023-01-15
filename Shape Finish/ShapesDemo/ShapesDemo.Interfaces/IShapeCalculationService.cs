using ShapesDemo.DTOs;

namespace ShapesDemo.Interfaces
{
    public interface IShapeCalculationService
    {
        decimal CalculateArea(ShapesDto shapeDto);

        decimal CalculatePerimeter(ShapesDto shapeDto);
    }
}
