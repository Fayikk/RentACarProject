using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolves.Autofac;
using DataAcces.Abstract;
using DataAcces.Concrete;



// Add services to the container.

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());//Dependency injection için gerekli adým.Autofac kullanýmý için hazýrlýk.
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());//Baðýmlýlýktan kurtulmak için IoC yapýlan dosyanýn yolunu veriyoruz.
});

//builder.Services.AddSingleton<ICarService, CarManager>();//Burada aynı şekilde bağımlılıklardan kurtulmak için yapılan bir yapıdır.
////Bu yapıda ICarService'i görürsen eğer CarManager'ı new'le anlmaına gelmketedir.
//builder.Services.AddSingleton<ICarDal, EfCarDal>();//Burada ise ICarDal görürsen,EfCarDal new'le anlamına gelmektedir.

////BRANDS
//builder.Services.AddSingleton<IBrandService, BrandManager>();
//builder.Services.AddSingleton<IBrandDal, EfBrandDal>();

////Colors
//builder.Services.AddSingleton<IColorService, ColorManager>();
//builder.Services.AddSingleton<IColorDal, EfColorDal>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
