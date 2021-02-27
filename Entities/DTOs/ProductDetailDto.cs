using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //DTO birden fazla yazılan tablonun join'i olduğu için IEntity(tek tablo) ile implemente olmaz!
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }

    }
}
