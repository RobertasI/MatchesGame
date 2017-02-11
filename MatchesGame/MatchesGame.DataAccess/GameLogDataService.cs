using MatchesGame.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchesGame.DataAccess
{
    public class GameLogDataService
    {
        public List<GameLog> GetAll()
        {
            using (var context = new MatchesGameContext())
            {
                return context.GameLog.ToList();
            }
        }

        public void Add(GameLog gameLog)
        {
            using (var context = new MatchesGameContext())
            {
                context.GameLog.Add(gameLog);
                context.SaveChanges();
            }
        }
    }
}
