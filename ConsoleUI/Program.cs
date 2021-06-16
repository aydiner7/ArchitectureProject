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
            CarTest();

            //CaseTypeTest();

            //BrandTest();

            //ColorTest();

            //FuelTypeTest();

        }

        private static void FuelTypeTest()
        {
            FuelTypeManager fuelTypeManager = new FuelTypeManager(new EfFuelTypeDal());
            fuelTypeManager.Add(new FuelType { FuelTypeName = "Elektrik" });
            var result = fuelTypeManager.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}", item.FuelTypeId, item.FuelTypeName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new CarValidationManager());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - ", 
                    item.BrandName, item.ModelName, item.ColorName, item.ModelYear, 
                    item.CaseTypeName, item.FuelTypeName, item.DailyPrice, item.Aciklama);
            }
        }

        private static void CaseTypeTest()
        {
            CaseTypeManager caseTypeManager = new CaseTypeManager(new EfCaseTypeDal());
            foreach (var item in caseTypeManager.GetAll())
            {
                Console.WriteLine("{0} / {1}", item.CaseTypeId, item.CaseTypeName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine("{0} / {1}", item.BrandId, item.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine("{0} / {1}", item.ColorId, item.ColorName);
            }
        }
    }
}
