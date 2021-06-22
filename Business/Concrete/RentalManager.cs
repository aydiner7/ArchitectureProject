using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        //IRentalValidationService _rentalValidationService;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
            //_rentalValidationService = rentalValidationService;
        }

        public IResult Add(Rental rental)
        {
            foreach (var item in _rentalDal.GetAll())
            {
                if (item.CarId==rental.CarId && item.Status==1)
                {
                    return new ErrorResult(Messages.CarReturnDate);
                }
                else if(item.CarId == rental.CarId && item.Status == 0)
                {
                    _rentalDal.Add(rental);
                    return new SuccessResult(Messages.CarRentaled);
                }
            }
            return new SuccessResult(Messages.CarRentaled);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalCarsListed);
        }

        public IDataResult<List<Rental>> GetByCarId(int CarId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(c => c.CarId == CarId), Messages.CarListed);
        }
    }
}
