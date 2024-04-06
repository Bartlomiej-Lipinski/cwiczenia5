using cwiczenia5.Models;

namespace cwiczenia5.DataBase;

public interface IDb
{
    public ICollection<Animal> GetAllAnimals();
    public Animal? GetById(int id);
    public void Add(Animal animal);
    public void Modify(Animal animal);
    public void Delete(int id);
    public void AddVisit(int animalId, Visit visit);
    public ICollection<Visit> GetVisits(int animalId); 
}