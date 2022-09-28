using ContextFM.Dtos;
using ContextFM.Interfaces;

namespace ContextFM.Services
{
    public class TriangleService : IShapeCalculationService
    {
        public decimal CalculateArea(ShapesDto shapeDto)
        {
            decimal area;

            area = (shapeDto.Breadth * shapeDto.Height) / 2;

            return area;
        }

        public decimal CalculatePerimeter(ShapesDto shapeDto)
        {
            decimal perimeter;

            perimeter = shapeDto.SideA + shapeDto.SideB + shapeDto.SideC;

            return perimeter;
        }
    }
}
