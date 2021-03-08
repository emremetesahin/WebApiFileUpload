using System;
using System.Collections.Generic;
using System.Text;

namespace UploadImage.Entities
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
