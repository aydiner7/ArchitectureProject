using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CaseType : IEntity
    {
        public int CaseTypeId { get; set; }

        public string CaseTypeName { get; set; }
    }
}
