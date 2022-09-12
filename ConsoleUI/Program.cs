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

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarName + " - " + car.BrandName);
            }
            Console.ReadKey();


        }

        //private static void Trying()
        //{
        //    //ColorManager colorManager = new ColorManager(new EfColorDal());
        //    //foreach (var color in colorManager.GetAll())
        //    //{
        //    //    Console.WriteLine(color.ColorName);
        //    //}
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

        //    //carManager.Add(new Car { BrandId = 4, CarId = 5, CarName = "Mercedes Amg", ColorId = 19, DailyPrice = 1221,Description="Clear",ModelYear="2022"});
        ////}
    }
}