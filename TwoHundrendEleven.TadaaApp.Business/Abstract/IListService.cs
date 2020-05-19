using System;
using System.Collections.Generic;
using System.Text;
using TwoHundrendEleven.TadaaApp.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.Business.Abstract
{
    interface IListService
    {
        //Buraya DTO yapısı koy. Direk entiti ile değil de DTO dan datayı oku.

       // Birde buraya generic result yapısı koy.
        List<List> GetLists();
        void Add(List list);
        void Update(List list);
        void Delete(List list);
    }
}
