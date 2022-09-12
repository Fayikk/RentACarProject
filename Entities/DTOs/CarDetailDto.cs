using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    //CRUD operasyonları(crate,Update,Delete,Remove)
    public class CarDetailDto:IDto
    {

        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
    }
}
