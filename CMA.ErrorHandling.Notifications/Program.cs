using CMA.ErrorHandling.Notifications.Domain.Interfaces;
using CMA.ErrorHandling.Notifications.Domain.Service;
using CMA.ErrorHandling.Notifications.Handling.Interface;
using CMA.ErrorHandling.Notifications.Handling.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI
builder.Services.AddScoped<INotificationService, NotificationService>();
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

app.MapControllers();

app.Run();
