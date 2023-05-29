using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public  interface ICategoryServices 
    {
       List<Category> GetList();
        void AddCategory(Category category);
        Category GetByID(int id);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
    }
}
