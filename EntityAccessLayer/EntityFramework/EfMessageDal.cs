using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Concrete;
using Entity_Layer.Concrete;
using EntityAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessagesDal
    {
    }
}
