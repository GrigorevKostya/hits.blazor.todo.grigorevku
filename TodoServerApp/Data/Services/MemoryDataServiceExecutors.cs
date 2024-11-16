using TodoServerApp.Components.Pages;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataServiceExecutors : IExecutorsDataService
    {
        private static IEnumerable<ExecutorsItem> executors { get; } =
    [
        new() { Id = 1, Surname="123", Name="Описан1 1", Patronymic="Опис2323ание  задачи 1"},
        new() { Id = 2, Surname="Зад23ача 2", Name="Описание2323  задачи 2", Patronymic="Описани2323е  задачи 2"},
        new() { Id = 3, Surname="Задач2323а 3", Name="Описание323  задачи 3", Patronymic="Описа2323ние  задачи 3"}
    ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExecutorsItem>> GetAllAsync()
        {
            return Task.FromResult(executors);
        }

        public Task<ExecutorsItem> GetExecutorAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(ExecutorsItem item)
        {
            throw new NotImplementedException();
        }
    }
}

