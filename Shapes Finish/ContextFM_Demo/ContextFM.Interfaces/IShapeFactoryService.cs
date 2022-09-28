using ContextFM.Common;

namespace ContextFM.Interfaces
{
    public interface IShapeFactoryService
    {
        public IShapeCalculationService CreateShapeCalculationService(ShapeEnum shapesEnum);
    }
}
