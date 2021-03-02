using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint - generic kısıt
    //class : referans tip olabilir demek
    //IEntity : IEntity olabilir veya IEntity implemente etmiş nesne olabilir.
    //new() : new'lenebilir olmalı
    //interfaceler newlenemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //GetAllByCategory(int categoryId); //ürünleri kategoriye göre filtrele expression ile gitti List<T> 
    }
}
