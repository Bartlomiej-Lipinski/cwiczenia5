using cwiczenia5.Enums;
using cwiczenia5.Models;

namespace cwiczenia5.DataBase;

public class Db : IDb
{
    private ICollection<Animal> _animals;

    public Db()
    {
        _animals = new List<Animal>()
        {
            new Animal()
            {
                furrColor = FurrColor.Black,
                Id = 1,
                Mass = 10,
                Name = "Azor",
                Rasa = Rasa.Pies,
                Visits = new List<Visit>()
                {
                    new Visit()
                    {
                        Date = "2021-10-10",
                        Description = "Wizyta kontrolna"
                    }
                }
            }
        };
    }

    public ICollection<Animal> GetAllAnimals()
    {
        return _animals;
    }

    public Animal? GetById(int id)
    {
        return _animals.FirstOrDefault(animal => animal.Id == id);
    }

    public void Add(Animal animal)
    {
        _animals.Add(animal);
    }

    public void Modify(Animal animal)
    {
        var animalToModify = _animals.FirstOrDefault(a => a.Id == animal.Id);
        if (animalToModify is null)
        {
            return;
        }

        animalToModify.furrColor = animal.furrColor;
        animalToModify.Mass = animal.Mass;
        animalToModify.Name = animal.Name;
        animalToModify.Rasa = animal.Rasa;
    }

    public void Delete(int id)
    {
        var animalToDelete = _animals.FirstOrDefault(a => a.Id == id);
        if (animalToDelete is null)
        {
            return;
        }

        _animals.Remove(animalToDelete);
    }

    public void AddVisit(int animalId, Visit visit)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == animalId);
        if (animal is null)
        {
            return;
        }

        animal.Visits.Add(visit);
    }

    public ICollection<Visit> GetVisits(int animalId)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == animalId);
        if (animal is null)
        {
            return new List<Visit>();
        }

        return animal.Visits;
    }
}