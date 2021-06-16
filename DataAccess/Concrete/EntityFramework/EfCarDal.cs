using Core.DataAccess.EntityFramework;
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
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join ca in context.CaseTypes
                             on c.CaseTypeId equals ca.CaseTypeId
                             join f in context.FuelTypes
                             on c.FuelTypeId equals f.FuelTypeId
                             select new CarDetailDto
                             {
                                 CarId=c.CarId, ModelName=c.ModelName,ModelYear=c.ModelYear,BrandName=b.BrandName, ColorName=co.ColorName, 
                                 CaseTypeName=ca.CaseTypeName, FuelTypeName=f.FuelTypeName,DailyPrice=c.DailyPrice ,Aciklama=c.Aciklama
                             };
                return result.ToList();
            }
        }
    }
}
