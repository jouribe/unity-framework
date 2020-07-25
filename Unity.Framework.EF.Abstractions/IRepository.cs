using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using URF.Core.Abstractions;

namespace Unity.Framework.EF.Abstractions
{
    public interface IRepository<TEntity, TDbContext> : IRepository<TEntity> where TEntity : class
    {
        void BulkInsert(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        void BulkUpdate(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        void BulkDelete(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        void BulkInsertOrUpdate(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        void BulkInsertOrUpdateOrDelete(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        void BulkRead(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        Task BulkInsertAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        Task BulkUpdateAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        Task BulkDeleteAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        Task BulkInsertOrUpdateAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        Task BulkInsertOrUpdateOrDeleteAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
        Task BulkReadAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null);
    }
}