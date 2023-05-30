using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface IWriterServices
    {
        List<Writer> GetList();
        void AddWriter(Writer writer);
        void DeleteWriter(Writer writer);
        void UpdateWriter(Writer writer);
        Writer GetByID(int id);
    }
}
