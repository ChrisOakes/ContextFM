using ShapesFM.Dtos;

namespace ShapesFM.Interfaces
{
    public interface IShapeCalculationService
    {
        decimal CalculateArea(ShapesDto shapeDto);

        decimal CalculatePerimeter(ShapesDto shapeDto);
    }
}
