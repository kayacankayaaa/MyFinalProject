using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //bu nesne bütün metotların dışında tanımlandığı için global değişken denir. ve _ ile başlar.
        List<Product> _products;

        //ctor - tab tab constracter oluşturur. Bellekte referans aldığı zaman çalışacak olan bloktur.
        public InMemoryProductDal() //voidsiz class ismi olursa consracter.
        {
            //oracle,sql server, posgres gibi yerlerden veri geliyormuş gibi simüle edilir.
            _products = new List<Product> {
                new Product {CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15 },
                new Product {CategoryId=1,ProductId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3 },
                new Product {CategoryId=2,ProductId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2 },
                new Product {CategoryId=2,ProductId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65 },
                new Product {CategoryId=2,ProductId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1 }
            };

        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //referans tip olduğu için remove komutu çalışmaz.
            //LINQ - Language Inregrated Query (dile gömülü sorgulama)
            //Lambda - =>

            //Product productToDelete = null;
            //foreach (var p in _products) //yukarıdaki productlar dolaşılıp listedeki eleman ile eşitlenir.
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }

            //}

            //her p için tüm kodları tek tek dolaşan tek satırlık kod. yukarıdaki foreach gibi.
            //Id olan aramalarda kullanılır. SingleOrDefault

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //metot

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll() //veritabanındaki data verilir ve döndürülür.
        {
            return _products;
        }

        public void Update(Product product) //güncellenecek ürün bilgisi
        {
            //gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            //where içindeki şarta uyan tüm elemanları yeni bir liste haline getirir ve döndürür.
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
