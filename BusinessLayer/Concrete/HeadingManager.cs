using BusinessLayer.Abstract;
using Entity_Layer.Concrete;
using EntityAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingServices
    {
        IHeadingDal _headingdal;

        public HeadingManager(IHeadingDal iheadingdal)
        {
            _headingdal = iheadingdal;
        }
         
        public void AddCategory(Heading heading)
        {
            _headingdal.Insert(heading);
        }

        public Heading GetByID(int id)
        {
            return _headingdal.Get(x =>x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _headingdal.List();
        }

        public void RemoveCategory(Heading heading)
        {
            _headingdal.Delete(heading);

        }

        public void UpdateCategory(Heading heading)
        {
            _headingdal.Update(heading);
        }
    }
}
