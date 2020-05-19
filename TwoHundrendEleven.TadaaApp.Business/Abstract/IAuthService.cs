using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;
using TwoHundredEleven.Core.Utilities.Jwt;
using TwoHundredEleven.Core.Utilities.Results;

namespace TwoHundrendEleven.TadaaApp.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(User user, string password);
        IDataResult<User> Login(User user,string password);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
