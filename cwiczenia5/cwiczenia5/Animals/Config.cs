﻿namespace cwiczenia5.Animals;

public static class Config
{
    public static IEndpointRouteBuilder RegisterAnimalsUserEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/animals", (IAnimalsService service) => TypedResults.Ok(service.GetAnimals()));
        endpoints.MapGet("/animals/{id:int}", (int id, IAnimalsService service) => TypedResults.Ok(service.GetAnimal(id)));
        endpoints.MapPost("/animals", (Animal animal, IAnimalsService service) => TypedResults.Created("", service.CreateAnimal(animal)));
        endpoints.MapPut("/animals/{id:int}", (int id, Animal animal, IAnimalsService service) =>
        {
            animal.Id = id;
            service.UpdateAnimal(animal);
            return TypedResults.NoContent();
        });
        endpoints.MapDelete("/animals/{id:int}", (int id, IAnimalsService service) =>
        {
            service.DeleteAnimal(id);
            return TypedResults.NoContent();
        });
        
        return endpoints;
    }
}