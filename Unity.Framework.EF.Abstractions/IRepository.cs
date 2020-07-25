using URF.Core.Abstractions;

namespace Unity.Framework.EF.Abstractions
{
    public interface IRepository<TEntity, TDbContext> : IRepository<TEntity> where TEntity : class
    {
        //
    }
}