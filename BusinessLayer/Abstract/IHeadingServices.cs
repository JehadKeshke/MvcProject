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
        List<Heading> GetListByWriter();
        void AddHeading(Heading heading);
        Heading GetByID(int id);
        void RemoveHeading(Heading heading);
        void UpdateHeading(Heading heading);
    }
}
