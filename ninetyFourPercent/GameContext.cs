using System.Data.Entity;

namespace ninetyFourPercent
{
    class GameContext : DbContext
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public GameContext() : base("DefaultConnection")
        {

        }

        #endregion

        public DbSet<Trade> Trades { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
