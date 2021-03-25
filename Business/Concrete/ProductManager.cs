using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            return _productDal.Get();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.Get(p=> p.CategoryId == id); //girilen id categoryId ye eşit ise filtrele
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.Get(p=> p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
