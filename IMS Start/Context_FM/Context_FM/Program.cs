using IMS.Data;
using IMS.Data.Implementations;
using IMS.Interfaces;
using IMS.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<IDatabaseContextFactory, DatabaseContextFactory>();

//builder.Services.AddDbContext<InventoryManagementContext>(options => options.UseSqlServer(config.GetConnectionString("IMSContext")));

builder.Services.AddDbContext<WhetherlyStockContext>(options => options.UseSqlServer(config.GetConnectionString("WhetherlyStockContext")));
builder.Services.AddDbContext<PorterInventorySolutionsContext>(options => options.UseSqlServer(config.GetConnectionString("PorterInventorySolutionsContext")));
builder.Services.AddDbContext<MapleWarehouseContext>(options => options.UseSqlServer(config.GetConnectionString("MapleWarehouseContext")));

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
