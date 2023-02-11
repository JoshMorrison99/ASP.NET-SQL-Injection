using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using VulnASP.NET_API.Models;

namespace VulnASP.NET_API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }    

        public DbSet<User> Users { get; set; }
    }
}
