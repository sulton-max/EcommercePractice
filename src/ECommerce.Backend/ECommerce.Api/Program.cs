using ECommerce.Api.Data.DataContexts;
using ECommerce.Api.Services.Products;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AppDataContext>().AddScoped<IProductsService, ProductsService>();

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();