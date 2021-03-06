using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }

        public string ModelName { get; set; }

        public string BrandName { get; set; }

        public string ColorName { get; set; }

        public string CaseTypeName { get; set; }

        public string FuelTypeName { get; set; }

        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }

        public string Aciklama { get; set; }
    }
}
