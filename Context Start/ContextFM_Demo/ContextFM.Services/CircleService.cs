using ContextFM.Dtos;
using ContextFM.Interfaces;

namespace ContextFM.Services
{
    public class CircleService : IShapeCalculationService
    {
        public decimal CalculateArea(ShapesDto shapeDto)
        {
            decimal area;

            area = Convert.ToDecimal(Math.PI * Math.Pow(Convert.ToDouble(shapeDto.Radius), 2));

            return area;
        }

        public decimal CalculatePerimeter(ShapesDto shapeDto)
        {
            decimal perimeter;

            perimeter = Convert.ToDecimal(2 * Math.PI * Convert.ToDouble(shapeDto.Radius));

            return perimeter;
        } 
    }
}
