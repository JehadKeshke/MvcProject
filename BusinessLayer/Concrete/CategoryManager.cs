using BusinessLayer.Abstract;
using Entity_Layer.Concrete;
using EntityAccessLayer.Abstract;
using EntityAccessLayer.Concrete.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryServices
    {
       
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);
        }
        public void RemoveCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }
    }
}
