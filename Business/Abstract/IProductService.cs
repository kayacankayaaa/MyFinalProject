using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //iş katmanında kullanılacak olan servis elemanları.
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id); //kategori id'ye göre filtreleme
        List<Product> GetByUnitPrice(decimal min, decimal max); //x ve y fiyat aralığında olan ürünleri getir


    }
}
