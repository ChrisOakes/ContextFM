using ContextFM.Dtos;
using ContextFM.Interfaces;

namespace ContextFM.Services
{
    public class SquareService : IShapeCalculationService
    {
        public decimal CalculateArea(ShapesDto shapeDto)
        {
            decimal area;

            area = Convert.ToDecimal(Math.Pow(Convert.ToDouble(shapeDto.Breadth), 2));

            return area;
        }

        public decimal CalculatePerimeter(ShapesDto shapeDto)
        {
            decimal perimeter;

            perimeter = 4 * (shapeDto.Breadth);

            return perimeter;
        }
    }
}
