using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarValidationManager : ICarValidationService
    {
        public bool Validate(Car car)
        {
            if (car.Aciklama.Length >= 2 && car.DailyPrice > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
