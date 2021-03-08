using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace UploadImage.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity>
    {
        public void Add(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);
        public TEntity Get(Expression<Func<TEntity, bool>> filter);
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

    }
}
