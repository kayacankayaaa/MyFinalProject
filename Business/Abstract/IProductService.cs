using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //iş katmanında kullanılacak olan servis elemanları.
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id); //kategori id'ye göre filtreleme
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max); //x ve y fiyat aralığında olan ürünleri getir
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product); //void yerine "IResult" yazılır
        



    }
}
