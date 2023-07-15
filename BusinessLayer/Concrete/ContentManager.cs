using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContetnServices
    {
        IContentDal contentDal;

        public ContentManager(IContentDal contactDal)
        {
            this.contentDal = contactDal;
        }

        public void AddContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            return contentDal.Get(x => x.ContentID == id);
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeading(int id)
        {
            return contentDal.List(x =>x.HeadingID == id);
        }

        public List<Content> GetListByWriter()
        {
            return contentDal.List(x => x.ContentID == 4);
        }

        public void RemoveContent(Content content)
        {
            throw new NotImplementedException();
        }

        public void UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
