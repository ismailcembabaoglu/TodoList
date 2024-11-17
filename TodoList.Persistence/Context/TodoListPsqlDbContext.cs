using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Domain.Mappings;
using TodoList.Domain.Models;

namespace TodoList.Persistence.Context
{
    public class TodoListPsqlDbContext:DbContext
    {
        public TodoListPsqlDbContext(DbContextOptions<TodoListPsqlDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Pano> Panos { get; set; }
        public virtual DbSet<DownPano> DownPanos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PanoMap());
            modelBuilder.ApplyConfiguration(new DownPanoMap());

            modelBuilder.Entity<DownPano>().HasOne(c => c.Pano).WithMany(c => c.DownPanos).HasForeignKey(c => c.PanoId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
