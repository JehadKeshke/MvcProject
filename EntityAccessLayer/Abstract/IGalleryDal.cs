using DataAccessLayer.Abstract;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAccessLayer.Abstract
{
    public interface IGalleryDal : IRepository<Gallery>
    {
    }
}
