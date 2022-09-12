using Business.Abstract;
using DataAcces.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Entities.Concrete.Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        List<Entities.Concrete.Color> IColorService.GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        //public List<Color> GetCarsByColorId(int colorId)
        //{
        //    return _colorDal.GetAll(a => a.ColorId == colorId);
        //}


    }
}
