using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint (jenerik kısıt)
    //class : referans tip olabilir demek.
    //T referans tip olmalı ve IEntity den bir class olmalı!
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir!
    //new() : new'lenebilir olmalı. IEntity interface olduğu için yalnızca somut nesneler adreslenebilir hale geldi!
    public interface IEntityRepository<T> where T:class,IEntity,new() //çalışılması gereken tip verilir.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre verebilme fonksiyonu, null olabilir
        T Get(Expression<Func<T, bool>> filter); // filtre null olamaz.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
