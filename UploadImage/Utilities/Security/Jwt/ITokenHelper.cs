using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Entities;

namespace UploadImage.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
