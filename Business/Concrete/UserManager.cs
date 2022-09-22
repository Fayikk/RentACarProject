using Business.Abstract;
using Core.Entities.Concrete;
using DataAcces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string mail)
        {
            return _userDal.Get(m => m.Email == mail);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            
            return _userDal.GetClaims(user);
        }
    }
}
