using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<ICarService, CarManager>();//Burada ayný þekilde baðýmlýlýklardan kurtulmak için yapýlan bir yapýdýr.
//Bu yapýda ICarService'i görürsen eðer CarManager'ý new'le anlmaýna gelmketedir.
builder.Services.AddSingleton<ICarDal, EfCarDal>();//Burada ise ICarDal görürsen,EfCarDal new'le anlamýna gelmektedir.

//BRANDS
builder.Services.AddSingleton<IBrandService, BrandManager>();
builder.Services.AddSingleton<IBrandDal, EfBrandDal>();

//Colors
builder.Services.AddSingleton<IColorService, ColorManager>();
builder.Services.AddSingleton<IColorDal, EfColorDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
