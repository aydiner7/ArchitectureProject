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
            //CarTest();

            //CaseTypeTest();

            //BrandTest();

            //ColorTest();

            //FuelTypeTest();

            //RentalTest();

            //RentalTest2();

            //UserTest();

            //UserTest2();

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //var result1 = customerManager.Add(new Customer { CompanyName = "GariBANK", UserId=3});
            //Console.WriteLine(result1.Message);

            var result2 = customerManager.GetAll();
            if (result2.Success==true)
            {
                Console.WriteLine(result2.Message);
                foreach (var item in result2.Data)
                {
                    Console.WriteLine(item.CompanyName);
                }
            }
        }

        private static void UserTest2()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.FirstName);
                }
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Egehan", LastName = "AYDINER", Email = "ege@hotmail.com", Password = "123" });
            Console.WriteLine(result.Message);
        }

        private static void RentalTest2()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ReturnDate);
                }
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 2, RentDate = DateTime.Now, ReturnDate=DateTime.Now});
            Console.WriteLine(result.Message);
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
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);

                foreach (var item in result.Data)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} ",
                        item.BrandName, item.ModelName, item.ColorName, item.ModelYear,
                        item.CaseTypeName, item.FuelTypeName, item.DailyPrice, item.Aciklama);
                }
            }
            else Console.WriteLine(result.Message);
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
