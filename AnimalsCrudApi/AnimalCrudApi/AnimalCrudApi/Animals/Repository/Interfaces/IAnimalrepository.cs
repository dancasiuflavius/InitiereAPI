using AnimalCrudApi.Animals.Model;
using AnimalCrudApi.Animals.Dto;


namespace AnimalCrudApi.Animals.Repository.Interfaces
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> GetAllAsync();
        //Task<Animal> GetByNameAsync(string name);
        //Task<Product> GetByIdAsync(int id);
        //Task<Product> CreateAsync(CreateProductRequest productRequest);
        //Task<Product> UpdateAsync(int id, UpdateProductRequest productRequest);
        //Task DeleteAsync(int id);
    }
}
