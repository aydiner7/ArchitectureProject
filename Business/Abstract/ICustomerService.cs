using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);

        IDataResult<List<Customer>> GetAll();

        IDataResult<List<Customer>> GetByCustomerId(int CustomerId);

        IDataResult<List<CustomerDetailDto>> GetDetails();
    }
}
