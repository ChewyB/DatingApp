using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        //Here we tell the entity framework about our models by using DbSet<ModelName>
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}