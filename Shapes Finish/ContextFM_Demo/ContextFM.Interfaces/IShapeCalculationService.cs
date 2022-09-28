using ContextFM.Dtos;

namespace ContextFM.Interfaces
{
    public interface IShapeCalculationService
    {
        decimal CalculateArea(ShapesDto shapeDto);

        decimal CalculatePerimeter(ShapesDto shapeDto);
    }
}
