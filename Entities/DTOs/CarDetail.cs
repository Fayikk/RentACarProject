using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetail
    {
        
        public string BrandName { get; set; }
        public int CarId { get; set; }

        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }

        public string CarName { get; set; }

        //public string? ImagePath { get; set; }
        public List<CarImages> CarImage { get; set; }

        public string ColorName { get; set; }
    }
}
