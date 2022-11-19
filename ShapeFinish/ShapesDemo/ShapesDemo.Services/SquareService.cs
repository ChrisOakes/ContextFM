using ShapesDemo.DTOs;
using ShapesDemo.Interfaces;

namespace ShapesDemo.Services
{
    public class SquareService : IShapeCalculationService
    {
        public decimal CalculateArea(ShapesDto shapeDto)
        {
            decimal area;

            if (shapeDto.Breadth == 0)
            {
                throw new Exception("The breadth is required when calculating the area of a square");
            }

            area = Convert.ToDecimal(Math.Pow(Convert.ToDouble(shapeDto.Breadth), 2));

            return area;
        }

        public decimal CalculatePerimeter(ShapesDto shapeDto)
        {
            decimal perimeter;

            if (shapeDto.Breadth == 0)
            {
                throw new Exception("The breadth is required when calculating the perimeter of a square");
            }

            perimeter = 4 * (shapeDto.Breadth);

            return perimeter;
        }
    }
}
