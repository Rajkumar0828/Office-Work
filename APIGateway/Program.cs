// using Microsoft.AspNetCore.Builder;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
// using Microsoft.AspNetCore.Hosting;
// using ApiGateway;

// namespace ApiGateway
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             CreateHostBuilder(args).Build().Run();
            
//         }
  
//         public static IHostBuilder CreateHostBuilder(string[] args) =>
//             Host.CreateDefaultBuilder(args)
//                 .ConfigureWebHostDefaults(webBuilder =>
//                 {
                     
//                     webBuilder.UseStartup<Startup>();
//                                                // Add Ocelot service
//                 })
//                 .ConfigureAppConfiguration((hostingContext, config) =>
//                 {
//                     config.AddJsonFile("configuration.json");
//                 });
//     }
// }



























using Ocelot.DependencyInjection;
using Ocelot.Middleware;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Configuration.SetBasePath(builder.Environment.ContentRootPath).AddJsonFile("Ocelot.json",optional:false,reloadOnChange:true);
// builder.Configuration.AddJsonFile("Ocelot.json");
builder.Services.AddOcelot();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseOcelot().Wait();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
// app.UseOcelot().Wait();

app.Run();
