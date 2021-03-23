using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Yapı hiç değişmedi, burada entityFramework e bir bağlılık söz konusu değil
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

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=> p.CategoryId == id); //girilen id categoryId ye eşit ise filtrele
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=> p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
