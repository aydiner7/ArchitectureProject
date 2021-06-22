using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class NewEStateRentalValidationManager : IRentalValidationService
    {
        public bool Validate(Rental rental)
        {
            return true;
        }
    }
}
