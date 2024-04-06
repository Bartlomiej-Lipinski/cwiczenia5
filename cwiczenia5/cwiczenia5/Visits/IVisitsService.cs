namespace cwiczenia5.Visits;

public interface IVisitsService
{
    public ICollection<Visit> GetVisits(int animalId);
    public int AddVisit(int animalId, Visit visit);
}