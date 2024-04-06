using cwiczenia5.Enums;

namespace cwiczenia5.Animals;

public class AnimalService : IAnimalsService
{
    private readonly IAnimalsRepository _animalRepository;

    public AnimalService(IAnimalsRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public ICollection<Animal> GetAnimals()
    {
        return _animalRepository.GetAnimals();
    }
    
    public Animal? GetAnimal(int id)
    {
        return _animalRepository.GetAnimal(id);
    }

    public int CreateAnimal(Animal animal)
    {
        return _animalRepository.CreateAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int id)
    {
        return _animalRepository.DeleteAnimals(id);
    }
    
}