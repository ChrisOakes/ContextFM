using ShapesDemo.DTOs;
using ShapesDemo.Interfaces;

namespace ShapesDemo.Services
{
    public class TriangleService : IShapeCalculationService
    {
        public decimal CalculateArea(ShapesDto shapeDto)
        {
            decimal area;

            if (shapeDto.Breadth == 0 || shapeDto.Height == 0)
            {
                throw new Exception("The breadth and perpendicular height are required when calculating the area of a triangle");
            }

            area = (shapeDto.Breadth * shapeDto.Height) / 2;

            return area;
        }

        public decimal CalculatePerimeter(ShapesDto shapeDto)
        {
            decimal perimeter;

            if (shapeDto.SideA == 0 || shapeDto.SideB == 0 || shapeDto.SideC == 0)
            {
                throw new Exception("SideA, SideB and SideC are required when calculating the perimeter of a triangle");
            }

            perimeter = shapeDto.SideA + shapeDto.SideB + shapeDto.SideC;

            return perimeter;
        }
    }
}
