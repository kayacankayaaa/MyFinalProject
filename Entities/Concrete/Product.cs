using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //class 'public' yapıldığı zaman bu class'a diğer katmanlarda ulaşabilir.
    //default class 'internal' olur ve sadece "entities" ona erişebilir.
    //İş yapan classların mutlaka interface leri oluşturulmalı!
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //short 'int'in bir küçüğü
        public decimal UnitPrice { get; set; }  // decimal - para birimi tutulur

    }
}
