﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarProjectContext context = new CarProjectContext())
            {
                var result = from ca in context.Cars
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             select new CarDetailDto { Id = ca.Id, BrandName = br.Name, ColorName = co.Name, ModelYear = ca.ModelYear, DailyPrice = ca.DailyPrice, Description = ca.Description };
                return result.ToList();
            }
        }
    }
}
