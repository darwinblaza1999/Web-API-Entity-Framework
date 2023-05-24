namespace APPWEBAPI.Interface
{
    public interface IUnitofWork
    {
        IProduct product { get; }
        Task CompleteAsync();
    }
}
