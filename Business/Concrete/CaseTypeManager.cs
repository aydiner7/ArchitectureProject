using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.AutoFac.Validation;
using Core.Utilities.Result;
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

        [ValidationAspect(typeof(CaseTypeValidator))]
        public IResult Add(CaseType caseType)
        {
            _caseTypeDal.Add(caseType);
            return new SuccessResult();
        }

        public IDataResult<List<CaseType>> GetAll()
        {
            return new SuccessDataResult<List<CaseType>>(_caseTypeDal.GetAll());
        }
    }
}
