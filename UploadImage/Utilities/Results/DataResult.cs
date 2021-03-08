using System;
using System.Collections.Generic;
using System.Text;

namespace UploadImage.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T Data,bool success):base(success)
        {

        }
        public T Data { get;}
    }
}
