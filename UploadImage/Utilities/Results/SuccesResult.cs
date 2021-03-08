using System;
using System.Collections.Generic;
using System.Text;

namespace UploadImage.Utilities.Results
{
    public class SuccesResult :Result
    {
        public SuccesResult(string message):base(true,message)
        {

        }
        public SuccesResult():base(true)
        {

        }
    }
}
