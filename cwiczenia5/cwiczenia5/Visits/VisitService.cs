namespace cwiczenia5.Visits;

public class VisitService : IVisitsService
{
    private readonly IVisitsRepository _visitsRepository;

    public VisitService(IVisitsRepository visitsRepository)
    {
        _visitsRepository = visitsRepository;
    }

    public int AddVisit(int animalId, Visit visit)
    {
        return _visitsRepository.AddVisit(animalId, visit);
    }

    public ICollection<Visit> GetVisits(int animalId)
    {
        return _visitsRepository.GetVisits(animalId);
    }
}