using MatchesGame.Domain;
using System.Data.Entity;

namespace MatchesGame.DataAccess
{
    public class MatchesGameContext : DbContext
    {
        public DbSet<GameLog> GameLog { get; set; }
    }
}
