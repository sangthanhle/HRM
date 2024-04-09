using Microsoft.Extensions.DependencyInjection;
using HRM.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using QLNS_HRM.Extensions;
using HRM.Domain.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy=>policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddDbContext<ApplicationDbContext>(options => { 
    options.UseSqlServer(builder.Configuration.GetConnectionString("HRMS")); });
//builder.Services.AddAutoMapper(typeof(Program));
//Enable CORS
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
      .AllowAnyHeader());
});
builder.Services.AddAutoMapper(typeof(ApplicationMapper));
builder.Services.AddAutoMapper(typeof(HRM_API.Mapper.Mapper));
builder.Services.RegisterService();
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
