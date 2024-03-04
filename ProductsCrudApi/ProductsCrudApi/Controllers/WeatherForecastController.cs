using Microsoft.AspNetCore.Mvc;
using ProductsCrudApi.Products.Model;
using ProductsCrudApi.Products.Repository.Interfaces;

namespace ProductsCrudApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IProductRepository _productRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger ,IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("test")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {



            var products = await _productRepository.GetAllAsync();


            return Ok(products);



        }
    }
}