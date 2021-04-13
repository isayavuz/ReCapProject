using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice<0)
            { 
                return new ErrorResult(Messages.CarDailyPriceInvalid);
            }
            _CarDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
        }

        public IResult Delete(Car car)
        {
            _CarDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==21)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(),Messages.CarGetAll);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_CarDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_CarDal.GetCarDetails(),Messages.CarGetAll);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Car car)
        {
            _CarDal.Update(car);
            return new SuccessResult();
        }
    }
}
