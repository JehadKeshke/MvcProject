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
        List<Message> GetListInbox(string p);
        List<Message> GetListSendbox(string p);
        void AddMessage(Message message);
        Message GetByID(int id);
        void RemoveMessage(Message message);
        void UpdateMessage(Message message);
    }
}
