namespace cwiczenia5.Visits;

public static class Config
{
    public static IEndpointRouteBuilder RegisterVisitsUserEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/vetClinic/Visits/{id:int}", (int id, IVisitsService service) => TypedResults.Ok(service.GetVisits(id)));
        endpoints.MapPost("/vetClinic/Visit/{id:int}", (int id,Visit visit, IVisitsService service) => TypedResults.Created("", service.AddVisit(id, visit)));
        return endpoints;
    }
}
