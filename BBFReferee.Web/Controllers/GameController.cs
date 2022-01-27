using BBFReferee.Web.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        public ActionResult Details(int id)
        {
            return View();
        }

       
    }
}
