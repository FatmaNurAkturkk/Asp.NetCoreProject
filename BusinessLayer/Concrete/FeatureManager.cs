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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelet(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public List<Feature> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
