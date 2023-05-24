using Entity_Layer.Concrete;
using EntityAccessLayer.Abstract;
using EntityAccessLayer.Concrete.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>, ICategoryDal
    {

    }
}
