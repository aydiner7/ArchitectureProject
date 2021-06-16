using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();

        Car GetById(int carId);

        List<CarDetailDto> GetCarDetails();
    }
}
