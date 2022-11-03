
namespace userVerify.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("server=localhost,1433;Database=basicAuth;User=sa;Password=Qwerty123456;");
        }
        public DbSet<Users> Users => Set<Users>();
    }
}