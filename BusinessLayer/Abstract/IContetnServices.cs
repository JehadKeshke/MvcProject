using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContetnServices
    {
        List<Content> GetList();
        List<Content> GetListByWriter();
        List<Content> GetListByHeading(int id);
        void AddContent(Content content);
        Content GetByID(int id);
        void RemoveContent(Content content);
        void UpdateContent(Content content);
    }
}
