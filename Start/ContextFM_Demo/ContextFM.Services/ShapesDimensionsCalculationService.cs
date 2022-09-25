namespace ContextFM.Services
{
    public class ShapesDimensionsCalculationService
    {
        //Square
        public decimal CalculateAreaSquare(decimal length)
        {
            decimal area = 0;

            area = Convert.ToDecimal(Math.Pow(Convert.ToDouble(length), 2));

            return area;
        }

        //Square
        public decimal CalculatePerimeterSquare(decimal length)
        {
            decimal perimeter = 0;

            perimeter = 4 * (length);

            return perimeter;
        }

        //Circle
        public decimal CalculateAreaCircle(decimal radius)
        {
            decimal area = 0;

            area = Convert.ToDecimal(Math.PI * Math.Pow( Convert.ToDouble(radius), 2));

            return area;
        }

        //Circle
        public decimal CalculatePerimeterCircle(decimal radius)
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
        public decimal CalculatePerimeterTriangle(decimal sideA, decimal sideB, decimal sideC)
        {
            decimal perimeter = 0;

            perimeter = sideA + sideB + sideC;

            return perimeter;
        }
    }
}
