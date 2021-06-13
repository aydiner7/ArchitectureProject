using Business.Concrete;
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
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var gelen = carManager.GetCars();

            var result = gelen.Where(p => p.ModelYear > 2005 && p.DailyPrice < 100000);

            foreach (var item in result)
            {
                Console.WriteLine(item.ModelYear + " model, " + item.DailyPrice + " TL, " + item.Aciklama);
            }
        }
    }
}
