using ShapesFM.Common;

namespace ShapesFM.Interfaces
{
    public interface IShapeFactoryService
    {
        public IShapeCalculationService CreateShapeCalculationService(ShapeEnum shapesEnum);
    }
}
