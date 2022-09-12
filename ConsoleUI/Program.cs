// Seusing System;

using Business.Concrete;
using DataAcces.Concrete;
using Entities.Concrete;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trying();

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetailDtos())
            //{
            //    Console.WriteLine(car.CarName + " - " + car.BrandName);
            //}
            //Console.ReadKey();
            //Brand brand = new Brand { BrandId = 7,BrandName="Veyron" };
            //BrandManager brandManager = new BrandManager(new EfBrandDal());       
            //brandManager.add(brand);

            //Car car = new Car { BrandId = 7, CarId = 20, CarName = "Bugatti", DailyPrice = 5000, ColorId = 15, Description = "SoClear", ModelYear = "2022" };
            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.add(car);


            //ProductDetailDto();

            //Silme işlemi
            //Brand brand1 = new Brand { BrandId = 11, BrandName = "Cruiser" };
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            ////brandManager.add(brand1);

            //brandManager.delete(brand1);


            //Güncelleme operasyonları

            //Brand brand = new Brand { BrandId=30,
            //BrandName="Sahin slx"};
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            ////brandManager.add(brand);
            //brandManager.Update(brand);




            //2 'li join ifadesi gerçekleştildi.
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetMixedDetailDtos())
            {
                Console.WriteLine(brand.CarName + " - " + brand.BrandName + " - " + brand.ColorName + " - " + brand.DailyPrice);
            }
        }

        private static void ProductDetailDto()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName);
            }
        }

        //private static void Trying()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    Car car1 = new Car();
        //    car1.CarId = 1;
        //    car1.CarName = "BMW M5";
        //    car1.BrandId = 12;
        //    car1.ColorId = 12;
        //    car1.DailyPrice = 0;
        //    car1.Description = "So Dirty";
        //    car1.ModelYear = "2022";
        //    carManager.Add(car1);

        //    carManager.Add(new Car { BrandId = 4, CarId = 5, CarName = "Mercedes Amg", ColorId = 19, DailyPrice = 1221, Description = "Clear", ModelYear = "2022" });
    }
    }
    