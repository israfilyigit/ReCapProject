using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarAdd();
            // CarDelete();
            // CarUpdate();
            // CarGetAll();
            GetCarDetail();
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 2, CarName = "MERCEDES", ModelYear = 2020, DailyPrice = 300, Description = "Alieye uygun" });
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 1});
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car {  CarId= 2, BrandId=2, ColorId=2, DailyPrice=60, ModelYear=1997, Description="Yolda Kalabilir", CarName="ŞAHİN"});
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void GetCarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName  +"-"+ car.BrandName +"-" + car.ColorName+"-"+ car.CarDailyInPrice);
            }
           
        }
    }
}
