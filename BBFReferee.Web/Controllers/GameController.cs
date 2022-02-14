using Microsoft.AspNetCore.Mvc;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;

namespace BBFReferee.Web.Controllers
{
    public class GameController : Controller
    {
        public readonly IGameViewModelService gameViewModelService;

        public GameController(IGameViewModelService gameViewModelService)
        {
            this.gameViewModelService = gameViewModelService;
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(GameViewModel gameViewModel)
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var games = this.gameViewModelService.GetAll();

            return View(games);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        { 
            var game = id.HasValue ? gameViewModelService.GetById(id.Value) : new GameViewModel();
            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GameViewModel game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }

            var id = game.Id;

            if (id == 0)
            {
                id = gameViewModelService.Add(game);
            }
            else
            {
                gameViewModelService.Edit(game);
            }

            return RedirectToAction(nameof(GetOne), new { id });
        }

        [HttpGet]
        public ActionResult GetOne(int id)
        {
            var game = gameViewModelService.GetById(id);
            return View(game);
        }

    }
}
