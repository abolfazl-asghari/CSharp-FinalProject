using Microsoft.EntityFrameworkCore;
using Model.DomainModels;

namespace Model
{
    public class FinalProjectDbContext : DbContext
    {
        #region [- ctor -]
        public FinalProjectDbContext()
        {
        }

        public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options) : base(options)
        {
        }
        #endregion

        #region [- OnConfiguring() -]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=.;Initial Catalog=FinalProjectDb;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=False");
            }
        }
        #endregion

        #region [- DbSets -]
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
        #endregion
    }
}
