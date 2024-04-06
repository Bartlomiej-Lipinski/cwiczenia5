namespace cwiczenia5.Animals;

public interface IAnimalsService
{
    public ICollection<Animal> GetAnimals();
    public Animal? GetAnimal(int id);
    public int CreateAnimal(Animal animal);
    public int UpdateAnimal(Animal animal);
    public int DeleteAnimal(int id);
}