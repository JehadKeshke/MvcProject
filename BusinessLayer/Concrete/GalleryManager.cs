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
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;
        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public List<Gallery> GetList()
        {
            return _galleryDal.List();
        }
    }
}
