using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);

        IDataResult<List<Rental>> GetAll();

        IDataResult<List<Rental>> GetByCarId(int CarId);
    }
}
