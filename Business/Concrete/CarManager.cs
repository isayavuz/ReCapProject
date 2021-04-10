using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                _CarDal.Add(car);
                Console.WriteLine("Araç bilgileri eklendi.");
            }
            else
            {
                Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _CarDal.Get(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _CarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}
