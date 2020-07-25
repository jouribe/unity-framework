using Unity.Framework.EF.CRM.CompleteCarParts.Context;
using Unity.Framework.EF.CRM.CompleteCarParts.Repositories.Contracts;
using Unity.Framework.EF.CRM.CompleteCarParts.UnitOfWork.Contracts;

namespace Unity.Framework.EF.CRM.CompleteCarParts.UnitOfWork
{
    public class ProductUnitOfWork : UnitOfWork<CompleteCarPartsDbContext>, IProductUnitOfWork
    {
        public ProductUnitOfWork(CompleteCarPartsDbContext context, IProductRepository productRepository) : base(context)
        {
            ProductRepository = productRepository;
        }

        public IProductRepository ProductRepository { get; }
    }
}