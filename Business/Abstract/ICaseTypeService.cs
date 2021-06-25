using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICaseTypeService
    {
        IResult Add(CaseType caseType);

        IDataResult<List<CaseType>> GetAll();
    }
}
