using Bank.Data;
using Bank.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountRepo , AccountRepo>();
builder.Services.AddScoped<IBranchRepo ,  BranchRepo>();
builder.Services.AddScoped<IRepoCustomer , RepoCustomer>();
builder.Services.AddDbContext<appdbcontext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("First_Connection")));
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
