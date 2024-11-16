using TodoServerApp.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data.Services
{
    public class MSSQLDataServiceExecutors(ApplicationDbContext context) : IExecutorsDataService
    {
        public async Task DeleteAsync(int id)
        {
            var executorItem = await context.Executors.FirstAsync(x => x.Id == id);
            context.Executors.Remove(executorItem);
            await context.SaveChangesAsync();
        }
        public async Task<ExecutorsItem> GetExecutorAsync(int id)
        {
            return await context.Executors.FirstAsync(x => x.Id == id);
        }
        public async Task<IEnumerable<ExecutorsItem>> GetAllAsync()
        {
            return await context.Executors.ToArrayAsync();
        }
        public async Task SaveAsync(ExecutorsItem executorItem)
        {
            Console.WriteLine(executorItem.Id);
            if (executorItem.Id == 0)
            {
                await context.Executors.AddAsync(executorItem);
            }
            else
            {
                context.Executors.Update(executorItem);
            }
            await context.SaveChangesAsync();
        }
    }
}
