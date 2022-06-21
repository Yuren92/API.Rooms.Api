using Microsoft.EntityFrameworkCore;
using Rooms.Api.CrossCutting.Register;
using Rooms.DataAccess;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("DataBaseConnection");


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<RoomsDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseConnection"));

});

builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy1",
        policy =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyMethod();
            policy.AllowAnyHeader();
        });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IoCRegister.AddRegistration(builder.Services);


builder.WebHost.UseKestrel(so =>
{
    so.Limits.MaxConcurrentConnections = 100;
    so.Limits.MaxConcurrentUpgradedConnections = 100;
    so.Limits.MaxRequestBodySize = 52428800;
    so.Listen(IPAddress.Loopback, port: 5002);
    so.Listen(IPAddress.Any, port: 80);
    so.Listen(IPAddress.Any, port: 443);
    so.Listen(IPAddress.Any, port: 8080);
    //so.Listen(IPAddress.Parse("54.173.33.193"), port: 80);
    //so.Listen(IPAddress.Parse("54.173.33.193"), port: 8080);
    so.ListenAnyIP(80, opts => opts.UseHttps());
    so.ListenAnyIP(443, opts => opts.UseHttps());
    so.ListenLocalhost(5004, opts => opts.UseHttps());
    so.ListenLocalhost(5005, opts => opts.UseHttps());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}/*else {
    app.UseSwagger();
app.UseSwaggerUI();
}*/
/*
app.UseCors(x => x.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());*/
app.UseCors();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
