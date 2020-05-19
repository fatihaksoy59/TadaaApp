using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;

namespace TwoHundredEleven.Core.Utilities.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
