namespace TodoServerApp.Data.Interfaces
{
    public interface IExecutorsDataService
    {
        Task<IEnumerable<ExecutorsItem>> GetAllAsync();
        Task SaveAsync(ExecutorsItem item);
        Task DeleteAsync(int id);
        Task<ExecutorsItem> GetExecutorAsync(int id);
    }
}
