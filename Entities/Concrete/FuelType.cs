using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FuelType : IEntity
    {
        public int FuelTypeId { get; set; }

        public string FuelTypeName { get; set; }
    }
}
