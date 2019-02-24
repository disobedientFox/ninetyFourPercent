using System.Data.Entity;

namespace ninetyFourPercent
{
    public class GameContext : DbContext
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public GameContext() : base("DefaultConnection")
        {

        }

        #endregion

        public DbSet<PlayerProgress> PlayersProgresses { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
