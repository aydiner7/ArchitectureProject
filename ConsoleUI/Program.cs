using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal(), new CarValidationManager());
            //carManager.AddCar(new Car {BrandId=3, ColorId=3, DailyPrice=176500, ModelYear=2019, Aciklama="Yarış Arabası"});
            
            foreach (var item in carManager.GetCars())
            {
                Console.WriteLine("{0} model {1}TL {2}", item.ModelYear, item.DailyPrice, item.Aciklama);
            }


            CaseTypeManager caseTypeManager = new CaseTypeManager(new EfCaseTypeDal());
            foreach (var item in caseTypeManager.GetAll())
            {
                Console.WriteLine("{0} / {1}", item.CaseTypeId, item.CaseTypeName);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine("{0} / {1}", item.BrandId, item.BrandName);
            }

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine("{0} / {1}", item.ColorId ,item.ColorName);
            }
        }
    }
}
