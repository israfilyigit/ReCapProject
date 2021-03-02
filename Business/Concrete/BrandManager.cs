using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        BrandManager _brandManager;

        public BrandManager(BrandManager brandManager)
        {
            _brandManager = brandManager; 
        }

        public void Add(Brand brand)
        {
            _brandManager.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandManager.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandManager.GetAll();
        }

        public void Update(Brand brand)
        {
            _brandManager.Update(brand);
        }
    }
}
