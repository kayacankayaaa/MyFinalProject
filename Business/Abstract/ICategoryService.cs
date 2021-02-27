using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //kategori ile dışarıya servis edilmek istenen komutlar yazılır
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);


    }
}
