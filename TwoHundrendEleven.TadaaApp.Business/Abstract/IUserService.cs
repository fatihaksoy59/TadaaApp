using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;

namespace TwoHundrendEleven.TadaaApp.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
