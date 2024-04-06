using cwiczenia5.Animals;
using cwiczenia5.Visits;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IAnimalsService,AnimalService>();
builder.Services.AddSingleton<IVisitsService,VisitService>();
builder.Services.AddSingleton<IAnimalsRepository,AnimalsRepository>();
builder.Services.AddSingleton<IVisitsRepository,VisitsRepository>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.RegisterAnimalsUserEndpoints();
app.RegisterVisitsUserEndpoints();
app.Run();