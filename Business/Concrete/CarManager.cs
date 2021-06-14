using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarValidationService _carValidationService;
        ICarDal _carDal;

        public CarManager(ICarDal carDal, ICarValidationService carValidationService)
        {
            _carDal = carDal;
            _carValidationService = carValidationService;
        }

        public List<Car> GetCars()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void AddCar(Car car)
        {
            if (_carValidationService.Validate(car) == true)
            {
                _carDal.Add(car);
                Console.WriteLine("Kayıt Gerçekleşti.");
            }
            else Console.WriteLine("Doğrulama Başarısız, Kayıt Başarısız.!");
        }
    }
}
