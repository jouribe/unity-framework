using Unity.Framework.EF.Abstractions;
using Unity.Framework.EF.CRM.CompleteCarParts.Context;
using Unity.Framework.EF.CRM.CompleteCarParts.Repositories.Contracts;

namespace Unity.Framework.EF.CRM.CompleteCarParts.UnitOfWork.Contracts
{
    public interface IProductsUnitOfWork : IUnitOfWork<CompleteCarPartsDbContext>
    {
        IProductRepository ProductRepository { get; }
    }
}