using Entity_Layer.Concrete;
using EntityAccessLayer.Concrete.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryaddBL(Category p)
        {
            if(p.CategoryName==""|| p.CategoryName.Length<=2 || p.CategoryName.Length>=51)
            {
                //hata mesage 
            }
            else
            {
                repo.Insert(p);
            }
        }

    }
}
