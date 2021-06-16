using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FuelTypeManager : IFuelTypeService
    {
        IFuelTypeDal _fuelTypeDal;

        public FuelTypeManager(IFuelTypeDal fuelTypeDal)
        {
            _fuelTypeDal = fuelTypeDal;
        }

        public List<FuelType> GetAll()
        {
            return _fuelTypeDal.GetAll();
        }

        public void Add(FuelType fuelType)
        {
            _fuelTypeDal.Add(fuelType);
            Console.WriteLine(fuelType.FuelTypeName+" eklendi.");
        }
    }
}
