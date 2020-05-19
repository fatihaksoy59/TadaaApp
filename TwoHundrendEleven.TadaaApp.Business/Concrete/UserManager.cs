using System;
using System.Collections.Generic;
using System.Text;
using TwoHundredEleven.Core.Entities.Concrete;
using TwoHundrendEleven.TadaaApp.Business.Abstract;
using TwoHundrendEleven.TadaaApp.DataAccess.Abstract;

namespace TwoHundrendEleven.TadaaApp.Business.Concrete
{
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
