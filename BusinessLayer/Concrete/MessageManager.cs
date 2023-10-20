using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IGenericService<Message>
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelet(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public List<Message> TGetListByFilter()
        {
            return _messageDal.GetList();
        }

        public List<Message> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
