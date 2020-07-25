using Microsoft.EntityFrameworkCore;
using Unity.Framework.EF.Abstractions;
using URF.Core.EF;

namespace Unity.Framework.EF
{
    public class UnitOfWork<TDbContext> : UnitOfWork, IUnitOfWork<TDbContext> where TDbContext : DbContext
    {
        public UnitOfWork(TDbContext context) : base(context)
        {
            //
        }
    }
}