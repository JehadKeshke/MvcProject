using Entity_Layer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void AddMessage(Message message);
        Message GetByID(int id);
        void RemoveMessage(Message message);
        void UpdateMessage(Message message);
    }
}
