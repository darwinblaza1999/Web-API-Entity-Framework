using APPWEBAPI.Models;

namespace APPWEBAPI.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<Response<T>> GetAsynce(int id);
        Task<Response<bool>> AddEntity(T entity);
        Task<Response<bool>> UpdateEntity(T entity);
        Task<Response<bool>> DeleteEntity(int id);
    }
}
