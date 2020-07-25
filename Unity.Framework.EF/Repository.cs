using Microsoft.EntityFrameworkCore;
using Unity.Framework.EF.Abstractions;
using URF.Core.EF;

namespace Unity.Framework.EF
{
    public class Repository<TEntity, TDbContext> : Repository<TEntity>, IRepository<TEntity, TDbContext> where TDbContext : DbContext where TEntity: class

    {
        public Repository(TDbContext context) : base(context)
        {
            //
        }
    }
}