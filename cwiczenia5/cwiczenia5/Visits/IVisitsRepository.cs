namespace cwiczenia5.Visits;

public interface IVisitsRepository
{
    int AddVisit(int animalId, Visit visit);
    ICollection<Visit> GetVisits(int animalId);
}