using ShapesDemo.Common;

namespace ShapesDemo.Interfaces
{
    public interface IShapeFactoryService
    {
        public IShapeCalculationService CreateShapeCalculationService(ShapeEnum shapeEnum);
    }
}
