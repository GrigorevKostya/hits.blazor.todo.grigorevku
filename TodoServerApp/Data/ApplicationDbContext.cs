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
                new() { Id = 1, Title="������ 1", Description="�������� ������ 1", CreatedDate = DateTime.Now },
                new() { Id = 2, Title="������ 2", Description="�������� ������ 2", CreatedDate = DateTime.Now },
                new() { Id = 3, Title="������ 3", Description="�������� ������ 3", CreatedDate = DateTime.Now },
                new() { Id = 4, Title="������ 4", Description="�������� ������ 4", CreatedDate = DateTime.Now },
            ]);
            builder.Entity<ExecutorsItem>().HasData([
                new() { Id = 1, Surname="123", Name="������1 1", Patronymic="����2323����  ������ 1"},
                new() { Id = 2, Surname="���23��� 2", Name="��������2323  ������ 2", Patronymic="�������2323�  ������ 2"},
                new() { Id = 3, Surname="�����2323� 3", Name="��������323  ������ 3", Patronymic="�����2323���  ������ 3"}
            ]);
        }
    }

}
