namespace ContextFM.Services
{
    public class ShapesCalculationService
    {
        //Square
        public decimal CalculateAreaSquare(decimal breadth, decimal height)
        {
            decimal area = 0;

            area = breadth * height;

            return area;
        }

        //Square
        public decimal CalculatePerimeter(decimal breadth, decimal height)
        {
            decimal perimeter = 0;

            perimeter = 2 * (breadth) + 2 * (height);

            return perimeter;
        }

        //Circle
        public decimal CalculateArea(decimal radius)
        {
            decimal area = 0;

            area = Convert.ToDecimal(Math.Pow(Math.PI * Convert.ToDouble(radius), 2));

            return area;
        }

        //Circle
        public decimal CalculatePerimeter(decimal radius)
        {
            decimal perimeter = 0;

            perimeter = Convert.ToDecimal(2 * Math.PI * Convert.ToDouble(radius));

            return perimeter;
        }

        //Triangle
        public decimal CalculateAreaTriangle(decimal breadth, decimal height)
        {
            decimal area = 0;

            area = (breadth * height) / 2;

            return area;
        }

        //Triangle
        public decimal CalculatePerimeter(decimal sideA, decimal sideB, decimal sideC)
        {
            decimal perimeter = 0;

            perimeter = sideA + sideB + sideC;

            return perimeter;
        }
    }
}
