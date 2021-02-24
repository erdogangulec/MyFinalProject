using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        InMemoryProductDal _productDal;
        private EfProductDal efProductDal;

        public ProductManager(InMemoryProductDal productDal)
        {
            _productDal = productDal;
        }

        public ProductManager(EfProductDal efProductDal)
        {
            this.efProductDal = efProductDal;
        }

        //public ProductManager(EfProductDal efProductDal)
        //{
        //}

        public List<Product> GetAllByCategoryId()
        {

            //iş kodları
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
