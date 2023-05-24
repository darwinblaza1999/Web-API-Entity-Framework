using APPWEBAPI.Interface;
using APPWEBAPI.Models;
using APPWEBAPI.Partial;

namespace APPWEBAPI.Repository
{
    public class ProductRepository:GenericRepository<Product>, IProduct
    {
        public ProductRepository(AppDbContext context):base (context)
        {
           
        }
        public override Task<List<Product>> GetAllAsync()
        {
            return base.GetAllAsync();
        }
    }
}
