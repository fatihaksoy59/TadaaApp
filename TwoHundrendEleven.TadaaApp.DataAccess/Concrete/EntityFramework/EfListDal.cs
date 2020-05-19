using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.DataAccess.EntityFramework;
using TwoHundrendEleven.TadaaApp.DataAccess.Abstract;
using TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Contexts;
using TwoHundrendEleven.TadaaApp.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework
{
    class EfListDal: EfEntityRepositoryBase<List,TadaaAppContext>,IListDal
    {
    }
}
