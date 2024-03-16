using AutoMapper;
using AnimalCrudApi.Data;
using AnimalCrudApi.Animals.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using AnimalCrudApi.Animals.Model;
using Microsoft.AspNetCore.Mvc;

namespace AnimalCrudApi.Animals.Repository
{
    public class AnimalRepository : IAnimalRepository
    {


        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public AnimalRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Animal>> GetAllAsync()
        {
            return await _context.Animals.ToListAsync();
        }

        //public async Task<Animal>GetByNameAsync(string name)
        //{
        //    return await _context.Animals.FirstOrDefaultAsync(animal => animal.FullName.Equals(name));
        //}
        //public async Task<ActionResult<Animal>> GetByName([FromRoute])
        //{
        //    var animal = await _context.Animals.GetByNameAsync(name);
        //}
    }
}
