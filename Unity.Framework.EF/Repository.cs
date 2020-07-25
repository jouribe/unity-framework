using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Unity.Framework.EF.Abstractions;
using URF.Core.EF;

namespace Unity.Framework.EF
{
    public class Repository<TEntity, TDbContext> : Repository<TEntity>, IRepository<TEntity, TDbContext> where TDbContext : DbContext where TEntity: class
    {
        protected Repository(TDbContext context) : base(context)
        {
            //
        }

        public void BulkInsert(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            Context.BulkInsert(entities, config, progress);
        }

        public void BulkUpdate(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            Context.BulkUpdate(entities, config, progress);
        }

        public void BulkDelete(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            Context.BulkDelete(entities, config, progress);
        }

        public void BulkInsertOrUpdate(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            Context.BulkInsertOrUpdate(entities, config, progress);
        }

        public void BulkInsertOrUpdateOrDelete(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            Context.BulkInsertOrUpdateOrDelete(entities, config, progress);
        }

        public void BulkRead(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            Context.BulkRead(entities, config, progress);
        }

        public async Task BulkInsertAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            await Context.BulkInsertAsync(entities, config, progress);
        }

        public async Task BulkUpdateAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            await Context.BulkUpdateAsync(entities, config, progress);
        }

        public async Task BulkDeleteAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            await Context.BulkDeleteAsync(entities, config, progress);
        }

        public async Task BulkInsertOrUpdateAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            await Context.BulkInsertOrUpdateAsync(entities, config, progress);
        }

        public async Task BulkInsertOrUpdateOrDeleteAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            await Context.BulkInsertOrUpdateOrDeleteAsync(entities, config, progress);
        }

        public async Task BulkReadAsync(IList<TEntity> entities, BulkConfig config = null, Action<decimal> progress = null)
        {
            await Context.BulkReadAsync(entities, config, progress);
        }
    }
}