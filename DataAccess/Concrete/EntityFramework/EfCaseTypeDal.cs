using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCaseTypeDal : ICaseTypeDal
    {
        public void Add(CaseType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CaseType entity)
        {
            throw new NotImplementedException();
        }

        public CaseType Get(Expression<Func<CaseType, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CaseType> GetAll(Expression<Func<CaseType, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<CaseType>().ToList()
                                      : context.Set<CaseType>().Where(filter).ToList();
            };
        }

        public void Update(CaseType entity)
        {
            throw new NotImplementedException();
        }
    }
}
