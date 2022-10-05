using ShapesFM.Dtos;
using ShapesFM.Interfaces;

namespace ShapesFM.Services
{
    public class CircleService : IShapeCalculationService
    {
        public decimal CalculateArea(ShapesDto shapeDto)
        {
            decimal area;

            if (shapeDto.Radius == 0)
            {
                throw new Exception("The radius is required when calculating the area of a circle");
            }

            area = Convert.ToDecimal(Math.PI * Math.Pow(Convert.ToDouble(shapeDto.Radius), 2));

            return area;
        }

        public decimal CalculatePerimeter(ShapesDto shapeDto)
        {
            decimal perimeter;

            if (shapeDto.Radius == 0)
            {
                throw new Exception("The radius is required when calculating the perimeter of a circle");
            }

            perimeter = Convert.ToDecimal(2 * Math.PI * Convert.ToDouble(shapeDto.Radius));

            return perimeter;
        }
    }
}
