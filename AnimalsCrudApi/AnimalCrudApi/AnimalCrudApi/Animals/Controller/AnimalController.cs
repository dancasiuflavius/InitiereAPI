
using Microsoft.AspNetCore.Mvc;
using AnimalCrudApi.Animals.Dto;
using AnimalCrudApi.Animals.Model;
using AnimalCrudApi.Animals.Repository;
using AnimalCrudApi.Animals.Repository.Interfaces;

namespace AnimalCrudApi.Animals.Controller
{
    [ApiController]
    [Route("Animals")]

    public class AnimalController : ControllerBase
    {
        private readonly ILogger<AnimalController> _logger;

        private readonly IAnimalRepository _animalRepository;

        public AnimalController(ILogger<AnimalController> logger, IAnimalRepository animalRepository)
        {
            _logger = logger;
            _animalRepository = animalRepository;
        }



        [HttpGet("api/v1/all")]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAll()
        {

            var animal = await _animalRepository.GetAllAsync();
            return Ok(animal);

        }


       
    }
}



