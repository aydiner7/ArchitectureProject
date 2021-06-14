using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class NewEStateCarValidationManager : ICarValidationService
    {
        public bool Validate(Car car)
        {
            return true;
        }
    }
}
