using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic
    //T değişkeni, yalnızca veritabanı nesnelerini(Entities-concrete) implemente edebilir.
    public interface IEntityRepository<T> where T:class, IEntity, new() 
    {
        //Bir listeden bir elemanı seçebilmek için yazılan kod satırıdır. Filtreleme yapılmasını sağlar.
        List<T> GetAll(Expression<Func<T, bool>> filter=null); 
        T GetT(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
