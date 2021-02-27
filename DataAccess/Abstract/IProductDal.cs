using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //product ile ilgili veritabanında yapılacak operasyonları(ekle,sil, güncelle vs.) içeren interface
    //Interface metotları default olarak public gelir.
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();


    }
}
//Code refactoring 