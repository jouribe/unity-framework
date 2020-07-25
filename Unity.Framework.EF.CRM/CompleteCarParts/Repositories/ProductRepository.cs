using Unity.Framework.EF.CRM.CompleteCarParts.Context;
using Unity.Framework.EF.CRM.CompleteCarParts.Models;
using Unity.Framework.EF.CRM.CompleteCarParts.Repositories.Contracts;

namespace Unity.Framework.EF.CRM.CompleteCarParts.Repositories
{
    public class ProductRepository : Repository<Product, CompleteCarPartsDbContext>, IProductRepository
    {
        public ProductRepository(CompleteCarPartsDbContext context) : base(context)
        {
            //
        }
    }
}