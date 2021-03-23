using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic yapısı, T ile bir değşken atamış olduk.
    public interface IEntityRepository<T> where T:class, IEntity, new() //T değişkeni, yalnızca veritabanı nesnelerini(Entities-concrete) implemente edebilir.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //Bir listeden bir elemanı seçebilmek için yazılan kod satırıdır. Filtreleme yapmamızı sağlar.
        T GetT(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
