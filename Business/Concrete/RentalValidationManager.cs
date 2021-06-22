using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalValidationManager : IRentalValidationService
    {
        public bool Validate(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return false;
            }
            else return true;
        }
    }
}
