using Microsoft.EntityFrameworkCore;
using PFEDal.Modeles;
using PFEServices.Administration.service;
using PFEServices.Article.services;
using PFEServices.Client.services;
using PFEServices.Fourniseur.services;
using PFEServices.UtilisateurS;

var builder = WebApplication.CreateBuilder(args);
var myAllowOrigins = "_myAllowOrigins";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PfeDbContext>(op =>

    op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"))
);
builder.Services.AddScoped<IUtilisateur, CUtilisateur>();
builder.Services.AddScoped<IAdministration, CAdministration>();
builder.Services.AddScoped<IFournisseur,CFournisseur>();
builder.Services.AddScoped<IClient, CClient>();
builder.Services.AddScoped<IArticle, CArticle>();

builder.Services.AddCors(Options =>
{
    Options.AddPolicy(name: myAllowOrigins,
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
              .AllowAnyMethod()
              .AllowAnyHeader();
        });

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(myAllowOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
