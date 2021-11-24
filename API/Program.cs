using API;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ElDbContext>(opt=>opt.UseNpgsql("Database=Test;Host=localhost;Port=5433;Username=postgres;Password=superpassword"));

builder.Services.AddGraphQLServer()
    .AddQueryType<QueryTest>();
var app = builder.Build();

app.MapGraphQL();

app.Run();
