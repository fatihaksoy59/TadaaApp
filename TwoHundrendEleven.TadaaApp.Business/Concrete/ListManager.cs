using System;
using System.Collections.Generic;
using System.Text;
using TwoHundrendEleven.TadaaApp.Business.Abstract;
using TwoHundrendEleven.TadaaApp.DataAccess.Abstract;
using TwoHundrendEleven.TadaaApp.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.Business.Concrete
{
    class ListManager : IListService
    {
        private readonly IListDal _listDal;

        public ListManager(IListDal listDal)
        {
            _listDal = listDal;
        }
        public void Add(List list)
        {
            _listDal.Add(list);
        }

        public void Delete(List list)
        {
            _listDal.Delete(list);
        }
        public void Update(List list)
        {
            _listDal.Update(list);
        }

        public List<List> GetLists()
        {
            return _listDal.GetList();
        }


    }
}
