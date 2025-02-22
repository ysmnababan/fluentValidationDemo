using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidationDemo.Controllers;
using FluentValidationDemo.Models;
using FluentValidationDemo.Repository;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Add FluentValidation with auto-validation and client-side adapters
builder.Services.AddFluentValidationAutoValidation()
        .AddFluentValidationClientsideAdapters();

// Register the validators from the assembly containing the UserValidator
builder.Services.AddValidatorsFromAssemblyContaining<UserValidator>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
