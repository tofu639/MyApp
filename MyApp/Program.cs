using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using MyApp.Repositories;
using MyApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Use In-memory database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

// Register repositories and services
// Ensure you use the correct repository with fully qualified names if there is ambiguity
builder.Services.AddScoped<MyApp.Data.ProductRepository>(); // If you're using the repository in Data
builder.Services.AddScoped<MyApp.Data.CustomerRepository>(); // If you're using the repository in Data
// Alternatively, if you need repositories from MyApp.Repositories, you can change it like this:
// builder.Services.AddScoped<MyApp.Repositories.ProductRepository>();
// builder.Services.AddScoped<MyApp.Repositories.CustomerRepository>();

builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CustomerService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Setup routing
app.MapControllers();

// Run the application
app.Run();
