using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Entities;
using UploadImage.Utilities.Results;

namespace UploadImage.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        IDataResult<List<User>> GetAllMember();

    }
}
