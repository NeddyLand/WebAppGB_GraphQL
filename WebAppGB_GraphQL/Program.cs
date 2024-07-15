using WebAppGB_GraphQL.Abstractions;
using WebAppGB_GraphQL.Data;
using WebAppGB_GraphQL.Graph.Mutation;
using WebAppGB_GraphQL.Mapper;
using WebAppGB_GraphQL.Repository;
using Microsoft.EntityFrameworkCore;
using WebAppGB_GraphQL.Graph.Query;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("db")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductGroupRepository, ProductGroupRepository>();
builder.Services.AddScoped<IStorageRepository, StorageRepository>();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
builder.Services.AddMemoryCache();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();
