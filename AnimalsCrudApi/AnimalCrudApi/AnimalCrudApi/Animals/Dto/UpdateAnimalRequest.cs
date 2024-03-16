using System;

namespace AnimalCrudApi.Animals.Dto;

public class UpdateAnimalRequest
{
    public string? FullName { get; set; }
    public string? Gendre { get; set; }
    public int? Age { get; set; }
}
