using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Business.Abstract;
using UploadImage.Business.Constants;
using UploadImage.DataAccess.Abstract;
using UploadImage.Entities;
using UploadImage.Utilities.Results;

namespace UploadImage.Business.Concrete
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

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
           return  _userDal.GetClaims(user);
        }

        public IDataResult<List<User>>GetAllMember()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.Listed);
        }
    }
}
