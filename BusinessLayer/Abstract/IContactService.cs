using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        void AddContact(Contact contact);
        Contact GetByID(int id);
        void RemoveContact(Contact contact);
        void UpdateContact(Contact contact);
    }
}
