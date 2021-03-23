using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Yapı hiç değişmedi, burada entityFrameWork e bir bağlılık söz konusu değil
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal) //Constractor
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }
    }
}
