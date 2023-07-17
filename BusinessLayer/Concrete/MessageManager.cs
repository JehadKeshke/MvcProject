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
    public class MessageManager : IMessageService
    {
        IMessagesDal _messagesDal;

        public MessageManager(IMessagesDal messagesDal)
        {
            _messagesDal = messagesDal;
        }

        public void AddMessage(Message message)
        {
            _messagesDal.Insert(message);
        }

        public Message GetByID(int id)
        {
            return _messagesDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox(string p)
        {
            return _messagesDal.List(x=>x.ReciverMail== p);
        }

        public List<Message> GetListSendbox(string p)
        {
            return _messagesDal.List(x=>x.SenderMail== p);
        }

        public void RemoveMessage(Message message)
        {
            _messagesDal.Delete(message);
            _messagesDal.Update(message);
        }

        public void UpdateMessage(Message message)
        {
            _messagesDal.Update(message);
        }
    }
}
