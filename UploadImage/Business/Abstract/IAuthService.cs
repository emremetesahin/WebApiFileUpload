using System;
using System.Collections.Generic;
using System.Text;
using UploadImage.Business.Abstract;
using UploadImage.Entities;
using UploadImage.Entities.Dtos;
using UploadImage.Utilities.Results;
using UploadImage.Utilities.Security.Jwt;

namespace UploadImage.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
