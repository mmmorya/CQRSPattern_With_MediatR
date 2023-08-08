using CQRSPattern_With_MediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSPattern_With_MediatR.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<StudentDetails> Students { get; set; }
    }
}
