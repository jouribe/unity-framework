using Microsoft.EntityFrameworkCore;
using Unity.Framework.EF.CRM.CompleteCarParts.Models;

namespace Unity.Framework.EF.CRM.CompleteCarParts.Context
{
    public class CompleteCarPartsDbContext : DbContext
    {
        public CompleteCarPartsDbContext(DbContextOptions<CompleteCarPartsDbContext> options) : base(options)
        {
            //
        }
        
        public DbSet<Product> Products { get; set; }
    }
}