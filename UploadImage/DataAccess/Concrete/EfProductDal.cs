using System.Text;
using UploadImage.DataAccess.Abstract;
using UploadImage.Entities;

namespace UploadImage.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, TestwindContext>,IProductDal
    {
    }
}
