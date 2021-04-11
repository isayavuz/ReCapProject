using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarsByColorId(8))
            //{
            //    Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} ModelYear:{3} DailyPrice:{4} Description:{5}",car.Id,car.BrandId,car.ColorId,car.ModelYear, car.DailyPrice, car.Description);
            //}

            //Console.WriteLine("---------------------------------------------------");
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("Renkler: "+ color.Name);
            //}

            //carManager.Add(new Car { BrandId = 47, ColorId = 12, ModelYear = 2019, DailyPrice = 250000, Description = "Mini Cooper, küçük ve tarz", });
            //Console.WriteLine("--------------------------------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Id:{0} BrandId:{1} ColorId:{2} ModelYear:{3} DailyPrice:{4} Description:{5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Id: " + car.Id);
                    Console.WriteLine("BrandName: " + car.BrandName);
                    Console.WriteLine("ColorName: " + car.ColorName);
                    Console.WriteLine("ModelYear: " + car.ModelYear);
                    Console.WriteLine("DailyPrice: " + car.DailyPrice);
                    Console.WriteLine("Description: " + car.Description);
                    Console.WriteLine("---------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Bilgilendirme: " + result.Success + " " + result.Message);
            }

            

            //carManager.Delete(new Car
            //{
            //    Id = 6,
            //    BrandId = 47,
            //    ColorId = 12,
            //    ModelYear = 2019,
            //    DailyPrice = 250000,
            //    Description = "Mini Cooper, 4X4"
            //});
            //Console.WriteLine("Yeni Liste:");
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("Id: " + car.Id);
            //    Console.WriteLine("BrandName: " + car.BrandName);
            //    Console.WriteLine("ColorName: " + car.ColorName);
            //    Console.WriteLine("ModelYear: " + car.ModelYear);
            //    Console.WriteLine("DailyPrice: " + car.DailyPrice);
            //    Console.WriteLine("Description: " + car.Description);
            //    Console.WriteLine("---------------------------------");
            //}
            Console.ReadLine();
        }
    }
}
