using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var item in carManager.GetCars())
            {
                Console.WriteLine("{0} model {1}TL {2}", item.ModelYear , item.DailyPrice, item.Aciklama);
            }


        }
    }
}
