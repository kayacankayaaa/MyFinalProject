using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet : kodların ayrı yazıldığı ortak bir noktada toplandığı alan.
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using içine yazılan nesneler işi bitince bellekten direkt atılır.
            //IDisposable pattern imlementation of c# = Using
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added; //nesneyi ekle
                context.SaveChanges(); //değişiklikleri kaydet
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted; //nesneyi sil
                context.SaveChanges(); //değişiklikleri kaydet
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
                //tabloya gidip verilen tek filtreyi döndürecek
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();
                //db'deki product tablosuna yerleş, listeye çevir ve ekrana ver. "select *from product"
                //filtre null ise product'ı ver, değilse filtre yap 
                

            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); //referansı yakala
                updatedEntity.State = EntityState.Modified; //nesneyi modifiye et
                context.SaveChanges(); //değişiklikleri kaydet
            }
        }
    }
}
