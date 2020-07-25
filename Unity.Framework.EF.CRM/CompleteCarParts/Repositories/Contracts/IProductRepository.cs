using Unity.Framework.EF.Abstractions;
using Unity.Framework.EF.CRM.CompleteCarParts.Context;
using Unity.Framework.EF.CRM.CompleteCarParts.Models;

namespace Unity.Framework.EF.CRM.CompleteCarParts.Repositories.Contracts
{
    public interface IProductRepository : IRepository<Product, CompleteCarPartsDbContext>
    {
        //
    }
}