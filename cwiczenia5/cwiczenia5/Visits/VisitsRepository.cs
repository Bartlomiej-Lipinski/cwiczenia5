namespace cwiczenia5.Visits;

public class VisitsRepository : IVisitsRepository
{
    private ICollection<Visit> _visits;

    public VisitsRepository()
    {
        _visits = new List<Visit>
        {
            new Visit
            {
                AnimalId = 1,
                Date = "2021-10-10",
                Description = "Wizyta kontrolna",
                Price = 50
            },
            new Visit
            {
                AnimalId = 2,
                Date = "2021-10-11",
                Description = "Szczepienie",
                Price = 100
            }
        };
    }

    public int AddVisit(int animalId, Visit visit)
    {
        visit.AnimalId = animalId;
        _visits.Add(visit);
        return 0;
    }

    public ICollection<Visit> GetVisits(int animalId)
    {
        return _visits.Where(v => v.AnimalId == animalId).ToList();
    }
}