using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingServices
    {
        List<Heading> GetList();
        void AddCategory(Heading heading);
        Heading GetByID(int id);
        void RemoveCategory(Heading heading);
        void UpdateCategory(Heading heading);
    }
}
