namespace cwiczenia5.Animals;

public interface IAnimalsRepository
{
    ICollection<Animal> GetAnimals();
    int CreateAnimal(Animal animal);
    Animal GetAnimal(int idAnimal);
    int UpdateAnimal(Animal student);
    int DeleteAnimals(int idAnimal);
}