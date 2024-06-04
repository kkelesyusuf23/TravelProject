using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.BusinessLayer.Concrete;
using CityTravelProject.DataAccessLayer.Abstract;
using CityTravelProject.DataAccessLayer.Concrete;
using CityTravelProject.DataAccessLayer.EntityFramework;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ILocationDal, EfLocationDal>();
builder.Services.AddScoped<ILocationService, LocationManager>();

builder.Services.AddScoped<IRouteDal, EfRouteDal>();
builder.Services.AddScoped<IRouteService, RouteManager>();

builder.Services.AddScoped<IRouteDetailDal, EfRouteDetailDal>();
builder.Services.AddScoped<IRouteDetailService, RouteDetailManager>();

builder.Services.AddScoped<ICityMapsDal, EfCityMapsDal>();
builder.Services.AddScoped<ICityMapsService, CityMapsManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IContactInformationDal, EfContactInformationDal>();
builder.Services.AddScoped<IContactInformationService, ContactInformationManager>();

builder.Services.AddScoped<IFutureDal, EfFutureDal>();
builder.Services.AddScoped<IFutureService, FutureManager>();

builder.Services.AddScoped<ITravelDestinationsDal, EfTravelDestinationsDal>();
builder.Services.AddScoped<ITravelDestinationsService, TravelDestinationsManager>();

builder.Services.AddDbContext<TravelContext>();
builder.Services.AddHttpClient();
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<TravelContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddHttpClient<CityTravelProject.BusinessLayer.GoogleMapsService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
