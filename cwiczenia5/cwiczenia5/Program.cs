using cwiczenia5;
using cwiczenia5.DataBase;
using cwiczenia5.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<IDb,Db>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/vetClinic/getAnimals", (IDb idb) =>
{
    return Results.Ok(idb.GetAllAnimals());
});
app.MapGet("/vetClinic/getAnimal/{id}", (IDb idb, int id) =>
{
    var animal = idb.GetById(id);
    if (animal is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(animal);
});
app.MapPost("/vetClinic/addAnimal", (IDb idb, Animal animal) =>
{
    idb.Add(animal);
    return Results.Created($"/vetClinic/getAnimal/{animal.Id}", animal);
});
app.MapPut("/vetClinic/modifyAnimal/", (IDb idb, Animal animal) =>
{
    idb.Modify(animal);
    return Results.Ok(animal);
});
app.MapDelete("/vetClinic/deleteAnimal/{id}", (IDb idb, int id) =>
{
    idb.Delete(id);
    return Results.Ok();
});
app.MapGet("/vetClinic/getVisits/{animalId}", (IDb idb, int animalId) =>
{
    if (idb.GetById(animalId) is null)
    {
        return Results.NotFound();
    }

    if (idb.GetVisits(animalId).Count == 0)
    {
        return Results.NoContent();
    }
    return Results.Ok(idb.GetVisits(animalId));
});
app.MapPost("/vetClinic/addVisit/{animalId}", (IDb idb, int animalId, Visit visit) =>
{
    if (idb.GetById(animalId)is null)
    {
        return Results.NotFound();
    }
    idb.AddVisit(animalId, visit);
    return Results.Created($"/vetClinic/getVisits/{animalId}", visit);
});
app.MapControllers();
app.Run();