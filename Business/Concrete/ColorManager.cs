using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        ColorManager _colorManager;

        public ColorManager(ColorManager colorManager)
        {
            _colorManager = colorManager;
        }

        public void Add(Color color)
        {
            _colorManager.Add(color);

        }

        public void Delete(Color color)
        {
            _colorManager.Delete(color);
        }

        public void Update(Color color)
        {
            _colorManager.Update(color);
        }

        public List<Color> GetAll()
        {
            return _colorManager.GetAll();
        }
    }
}
