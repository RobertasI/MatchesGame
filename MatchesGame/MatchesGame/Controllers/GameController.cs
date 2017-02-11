using MatchesGame.DataAccess;
using MatchesGame.Domain;
using MatchesGame.Models;
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

                return RedirectToAction("PlayGame");
            }

            return View(gameViewModel);
        }

        public ActionResult PlayGame()
        {
            return View();
        }
        //// GET: Player/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Player/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Player/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Player/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Player/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Player/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Player/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
