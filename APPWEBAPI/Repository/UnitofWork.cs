using APPWEBAPI.Interface;
using APPWEBAPI.Partial;

namespace APPWEBAPI.Repository
{
    public class UnitofWork : IUnitofWork
    {
        public IProduct product { get; private set; }
        private readonly AppDbContext dbContext;
        public UnitofWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            product = new ProductRepository(dbContext);
        }

        public async Task CompleteAsync()
        {
            await this.dbContext.SaveChangesAsync();
        }
    }
}
