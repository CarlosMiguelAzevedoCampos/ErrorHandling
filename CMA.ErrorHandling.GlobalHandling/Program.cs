using CMA.ErrorHandling.Exceptions.ErrorHandler;
using CMA.ErrorHandling.GlobalHandling.Domain.Interfaces;
using CMA.ErrorHandling.GlobalHandling.Domain.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// DI
builder.Services.AddScoped<IErrorHandlingService, ErrorHandlingService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


// Middleware 
app.UseMiddleware<ErrorHandlerMiddleware>();

app.MapControllers();

app.Run();
