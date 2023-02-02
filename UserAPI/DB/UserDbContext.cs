using Microsoft.EntityFrameworkCore;
using UserAPI.Entities;

namespace UserAPI.DB
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Data> datas { get; set; }



    }


}
