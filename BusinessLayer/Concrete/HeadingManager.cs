using BusinessLayer.Abstract;
using Entity_Layer.Concrete;
using DataAccessLayer.Abstract;
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
         
        public void AddHeading(Heading heading)
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

        public void RemoveHeading(Heading heading)
        {
            heading.HeadingStatus = false;
            _headingdal.Update(heading);
        }

        public void UpdateHeading(Heading heading)
        {
            _headingdal.Update(heading);
        }
    }
}
