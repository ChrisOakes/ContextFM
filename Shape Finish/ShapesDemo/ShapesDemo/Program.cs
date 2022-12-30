using ShapesDemo.Interfaces;
using ShapesDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IShapeFactoryService, ShapeFactoryService>();

builder.Services.AddScoped<SquareService>()
    .AddScoped<IShapeCalculationService, SquareService>(x => x.GetService<SquareService>());

builder.Services.AddScoped<TriangleService>()
    .AddScoped<IShapeCalculationService, TriangleService>(x => x.GetService<TriangleService>());

builder.Services.AddScoped<CircleService>()
    .AddScoped<IShapeCalculationService, CircleService>(x => x.GetService<CircleService>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
