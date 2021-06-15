using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CaseTypeManager : ICaseTypeService
    {
        ICaseTypeDal _caseTypeDal;

        public CaseTypeManager(ICaseTypeDal caseTypeDal)
        {
            _caseTypeDal = caseTypeDal;
        }

        public List<CaseType> GetAll()
        {
            return _caseTypeDal.GetAll();
        }
    }
}
