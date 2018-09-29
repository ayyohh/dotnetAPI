using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DNApi.API.Models;

namespace DNApi.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    
    }
}