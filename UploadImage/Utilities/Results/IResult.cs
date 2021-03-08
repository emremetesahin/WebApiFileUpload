using System;
using System.Collections.Generic;
using System.Text;

namespace UploadImage.Utilities.Results
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get;}
    }
}
