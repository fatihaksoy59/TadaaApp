using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.DataAccess.EntityFramework;
using TwoHundredEleven.Core.Entities.Concrete;
using System.Linq;
using TwoHundrendEleven.TadaaApp.DataAccess.Abstract;
using TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework.Contexts;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TadaaAppContext>, IUserDal
    {

        public List<OperationClaim> GetClaims(User user)

        { // Geri Dönüş değerini de DTO yapsak güzel olabilir.
            using (var context = new TadaaAppContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.userId == user.id
                             select new OperationClaim { id = operationClaim.id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
