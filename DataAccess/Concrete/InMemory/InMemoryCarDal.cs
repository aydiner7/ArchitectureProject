using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2010, DailyPrice=16000, Aciklama="Arazi için uygun."},
                new Car{CarId=2, BrandId=1, ColorId=4, ModelYear=1997, DailyPrice=8700, Aciklama="Uzun mesafe için uygun."},
                new Car{CarId=3, BrandId=2, ColorId=2, ModelYear=2005, DailyPrice=37500, Aciklama="Şehir içi için uygun."},
                new Car{CarId=4, BrandId=2, ColorId=5, ModelYear=2021, DailyPrice=153000, Aciklama="Gösteriş için uygun"},
                new Car{CarId=5, BrandId=3, ColorId=3, ModelYear=2016, DailyPrice=98750, Aciklama="Konfor için uygun."},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteToCar = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(DeleteToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Aciklama = car.Aciklama;
        }

        
    }
}
