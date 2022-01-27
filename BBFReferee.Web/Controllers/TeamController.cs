using Microsoft.AspNetCore.Mvc;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;

namespace BBFReferee.Web.Controllers
{
    public class TeamController : Controller
    {
        public readonly ITeamViewModelService teamViewModelService;

        public TeamController(ITeamViewModelService teamViewModelService)
        {
            this.teamViewModelService = teamViewModelService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TeamViewModel teamViewModel)
        {
            return View(teamViewModel);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var team = id.HasValue ? teamViewModelService.GetById(id.Value) : new TeamViewModel();
            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TeamViewModel team)
        {
            if (!ModelState.IsValid)
            {
                return View(team);
            }

            var id = team.Id;

            if (id == 0)
            {
                id = teamViewModelService.Add(team);
            }
            else
            {
                teamViewModelService.Edit(team);
            }

            return RedirectToAction(nameof(User), new { id });
        }
    }
}
