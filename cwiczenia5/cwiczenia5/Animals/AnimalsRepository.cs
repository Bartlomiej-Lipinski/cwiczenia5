using cwiczenia5.Enums;

namespace cwiczenia5.Animals;

public class AnimalsRepository : IAnimalsRepository
{
    private ICollection<Animal> _animals;
    public AnimalsRepository()
    {
        _animals = new List<Animal>
        {
            new Animal
            {
                Id = 1,
                Name = "Burek",
                Rasa = Rasa.Pies,
                Mass = 10,
                furrColor = FurrColor.Brown
            },
            new Animal
            {
                Id = 2,
                Name = "Mruczek",
                Rasa = Rasa.Kot,
                Mass = 5,
                furrColor = FurrColor.Black
            }
        };
    }
    public ICollection<Animal> GetAnimals()
    {
        return _animals;
    }

    public int CreateAnimal(Animal animal)
    {
        _animals.Add(animal);
        return 0;
    }

    public Animal GetAnimal(int idAnimal)
    {
        var chosen = _animals.FirstOrDefault(a => a.Id == idAnimal);
        if (chosen is null)
        {
            return null;
        }

        return chosen;
    }

    public int UpdateAnimal(Animal student)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == student.Id);
        if (animal is null)
        {
            return 1;
        }

        animal.Name = student.Name;
        animal.Rasa = student.Rasa;
        animal.Mass = student.Mass;
        animal.furrColor = student.furrColor;
        return 0;
    }

    public int DeleteAnimals(int idAnimal)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == idAnimal);
        if (animal is null)
        {
            return 1;
        }

        _animals.Remove(animal);
        return 0;
    }
}