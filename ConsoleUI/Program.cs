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
            //carManager.AddCar(new Car {BrandId=2, ColorId=2, DailyPrice=13000, ModelYear=1988, Aciklama="Yayla Arabası" });
            


            foreach (var item in carManager.GetCars())
            {
                Console.WriteLine("{0} model {1}TL {2}", item.ModelYear, item.DailyPrice, item.Aciklama);
            }
        }
    }
}
