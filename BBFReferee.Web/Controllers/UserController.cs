using Microsoft.AspNetCore.Mvc;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;

namespace BBFReferee.Web.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserViewModelService userViewModelService;

        public UserController(IUserViewModelService userViewModelService)
        {
            this.userViewModelService = userViewModelService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            //var user = this.userViewModelService.GetById(id);
            //if (user == null)
            //{
            //    return Content("Нет юзера");
            //}
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(UserViewModel userViewModel)
        {
            //var user = this.userViewModelService.GetById(id);
            //if (user == null)
            //{
            //    return Content("Нет юзера");
            //}
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var users = this.userViewModelService.GetAll();

            return View(users);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var user = id.HasValue ? userViewModelService.GetById(id.Value) : new UserViewModel();

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var id = user.Id;

            if (id == 0)
            {
                id = userViewModelService.Add(user);
            }
            else
            {
                userViewModelService.Edit(user);
            }

            return RedirectToAction(nameof(GetOne), new { id });
        }

        [HttpGet]
        public ActionResult GetOne(int id)
        {
            var user = userViewModelService.GetById(id);
            return View(user);
        }
    }
}
