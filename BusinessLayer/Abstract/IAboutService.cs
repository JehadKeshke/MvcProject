using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void AddAbout(About about);
        About GetByID(int id);
        void RemoveAbout(About about);
        void UpdateAbout(About about);
    }
}
