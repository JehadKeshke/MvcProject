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
    public class WriterManager : IWriterServices
    {
        IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public void AddWriter(Writer writer)
        {
            _writerdal.Insert(writer);

        }

        public void DeleteWriter(Writer writer)
        {
            _writerdal.Delete(writer);    
        }

        public Writer GetByID(int id)
        {
            return _writerdal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerdal.List();
        }

        public void UpdateWriter(Writer writer)
        {
            _writerdal.Update(writer);
        }
    }
}
