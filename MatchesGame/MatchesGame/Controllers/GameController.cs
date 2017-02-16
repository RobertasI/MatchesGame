using MatchesGame.DataAccess;
using MatchesGame.Domain;
using MatchesGame.Models;
using System;
using System.Web.Mvc;

namespace MatchesGame.Controllers
{
    public class GameController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(GameViewModel gameViewModel)
        {
            if (ModelState.IsValid)
            {
                var gameLogDataService = new GameLogDataService();
                var gameLog = new GameLog
                {
                    PlayerName = "-",
                    Time = System.DateTime.Now,
                    Action = gameViewModel.PlayerOne + " and " + gameViewModel.PlayerTwo + " started the game"
                };

                gameLogDataService.Add(gameLog);

                return View("Game", gameViewModel);            
            }

            return View(gameViewModel);
        }

        public ActionResult Game(GameViewModel gameViewModel)
        {
            return View(gameViewModel);
        }

        [HttpPost]
        public ActionResult Game(string Name, string Action)
        {
            Console.WriteLine(Name, Action);
            var gameLogDataService = new GameLogDataService();
            var gameLog = new GameLog
            {
                PlayerName = Name,
                Time = System.DateTime.Now,
                Action = Action
            };
            

            gameLogDataService.Add(gameLog);
            return PartialView();
        }
    }
}
