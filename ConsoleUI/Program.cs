using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //S'O'LID
    //Open Closed Principle = yapılan yazılıma yeni bir özellik eklendiğinde, mevcuttaki hiçbir koda dokunamazsın!
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }

            
        }
    }
}
