using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public void Add(Entities.Concrete.Color color)
        {
            _colorDal.Add(color);
        }

        public void delete(Entities.Concrete.Color color)
        {
            _colorDal.Delete(color);
        }

        public IDataResult<List<Entities.Concrete.Color>> GetAll()
        {
            return new DataResult<List< Entities.Concrete.Color >>(_colorDal.GetAll(),true,Messages.SuccessMessages);
        }

        //public IDataResult<List<Color>> GetCarsByColorId(int colorId)
        //{
            
        //}

        public void Update(Entities.Concrete.Color color)
        {
            _colorDal.Update(color);
        }

        IDataResult<List<Entities.Concrete.Color>> IColorService.GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Entities.Concrete.Color>>(_colorDal.GetAll(a => a.ColorId == colorId), Messages.SuccessMessages);
        }



        //public List<Color> GetCarsByColorId(int colorId)
        //{
        //    return _colorDal.GetAll(a => a.ColorId == colorId);
        //}


    }
}
