using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        public virtual DbSet<ExecutorsItem> Executors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new() { Id = 1, Title="Задача 1", Description="Описание задачи 1", CreatedDate = DateTime.Now },
                new() { Id = 2, Title="Задача 2", Description="Описание задачи 2", CreatedDate = DateTime.Now },
                new() { Id = 3, Title="Задача 3", Description="Описание задачи 3", CreatedDate = DateTime.Now },
                new() { Id = 4, Title="Задача 4", Description="Описание задачи 4", CreatedDate = DateTime.Now },
            ]);
            builder.Entity<ExecutorsItem>().HasData([
                new() { Id = 1, Surname="123", Name="Описан1 1", Patronymic="Опис2323ание  задачи 1"},
                new() { Id = 2, Surname="Зад23ача 2", Name="Описание2323  задачи 2", Patronymic="Описани2323е  задачи 2"},
                new() { Id = 3, Surname="Задач2323а 3", Name="Описание323  задачи 3", Patronymic="Описа2323ние  задачи 3"}
            ]);
        }
    }

}
