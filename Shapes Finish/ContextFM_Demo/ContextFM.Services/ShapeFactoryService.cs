using ShapesFM.Common;
using ShapesFM.Interfaces;

namespace ShapesFM.Services
{
    public class ShapeFactoryService : IShapeFactoryService
    {
        private readonly IServiceProvider _serviceProvider;

        public ShapeFactoryService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IShapeCalculationService CreateShapeCalculationService(ShapeEnum shapeEnum) => shapeEnum switch
        {
            ShapeEnum.Circle => (IShapeCalculationService)_serviceProvider.GetService(typeof(CircleService)),
            ShapeEnum.Triangle => (IShapeCalculationService)_serviceProvider.GetService(typeof(TriangleService)),
            ShapeEnum.Square => (IShapeCalculationService)_serviceProvider.GetService(typeof(SquareService)),
            _ => throw new Exception("A shape type is required")
        };
    }
}
