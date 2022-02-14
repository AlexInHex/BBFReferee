using Microsoft.AspNetCore.Mvc;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;
using BBFReferee.Core.Entities;

namespace BBFReferee.Web.Controllers
{
    public class SityController : Controller
    {
        public readonly ISityViewModelService sityViewModelService;

        public SityController(ISityViewModelService sityViewModelService)
        {
            this.sityViewModelService = sityViewModelService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(UserViewModel userViewModel)
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var sities = this.sityViewModelService.GetAll();

            return View(sities);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var sity = id.HasValue ? sityViewModelService.GetOne(id.Value) : new SityViewModel();

            return View(sity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SityViewModel sity)
        {
            if (!ModelState.IsValid)
            {
                return View(sity);
            }

            var id = sity.Id;

            if (id == 0)
            {
                id = sityViewModelService.Add(sity);
            }
            else
            {
                sityViewModelService.Edit(sity);
            }

            return RedirectToAction(nameof(Sity), new { id });
        }
    }
}