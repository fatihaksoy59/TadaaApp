using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.DataAccess;
using TwoHundredEleven.Core.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
