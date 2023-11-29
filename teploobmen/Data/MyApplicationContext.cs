using Microsoft.EntityFrameworkCore;

namespace teploobmen.Data
{
    public class MyApplicationContext : DbContext
    {
        public  DbSet<InputData> InputDatas { get; set; }

        public DbSet<User> Users { get; set; }

        public MyApplicationContext(DbContextOptions<MyApplicationContext> options) : base(options)
        {
        
        }
    }
}
