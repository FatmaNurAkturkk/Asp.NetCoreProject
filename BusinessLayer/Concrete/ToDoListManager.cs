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
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDiListDal;

        public ToDoListManager(IToDoListDal toDiListDal)
        {
            _toDiListDal = toDiListDal;
        }

        public void TAdd(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void TDelet(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetList()
        {
           return _toDiListDal.GetList();
        }

        public List<ToDoList> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            throw new NotImplementedException();
        }
    }
}
