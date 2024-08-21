using BudgetApp.Api.DataAccess.Data;
using BudgetApp.Api.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register graphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<BookQueries>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BudgetAppConnectionString")));

var app = builder.Build();
    
app.MapGraphQL();
app.Run();