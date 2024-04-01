using Microsoft.AspNetCore.Mvc;
using LoginDemo1.OtherOperation;
using LoginDemo1.DataContext;

namespace LoginDemo1.Controllers

{
    [ApiController]
    [Route("/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfiguration _configuration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        [HttpGet]

        //[CustomRoleAuthorizeAttributes("430a9459-e1e5-47b8-9a91-e299df67bd41")]

        [CustomRoleAuthorize("9f0990db-2bb2-414e-9f12-3c89e20d6fc8")]
        public IEnumerable<WeatherForecast> Get()
        {


            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
