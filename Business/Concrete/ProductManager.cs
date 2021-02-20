using Business.Abstract;
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

        public ProductManager(InMemoryProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {

            //iş kodları
            return _productDal.GetAll();
        }
    }
}
