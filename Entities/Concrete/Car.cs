using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }

        public int BrandId { get; set; }

        public int ColorId { get; set; }

        public int CaseTypeId { get; set; }

        public int FuelTypeId { get; set; }

        public string ModelName { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string Aciklama { get; set; }
    }
}
