﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : IGenericService<Skill>
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelet(Skill t)
        {
            _skillDal.Delete(t);
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public List<Skill> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
