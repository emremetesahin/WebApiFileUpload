using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Entities;

namespace UploadImage.DataAccess.Abstract
{
    public  interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
