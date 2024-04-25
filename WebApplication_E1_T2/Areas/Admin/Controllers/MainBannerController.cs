using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_E1_T2.Domain;
using WebApplication_E1_T2.Domain.Entities;
using WebApplication_E1_T2.Service;

namespace WebApplication_E1_T2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainBannerController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public MainBannerController(DataManager _dataManager , IWebHostEnvironment _hostingEnvironment)
        {
            this.dataManager = _dataManager;
            this.hostingEnvironment = _hostingEnvironment;
        }

        public IActionResult Edit()
        {
            var entity = dataManager.MainBanner.GetFirstMainBanner();
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(MainBanner model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.MainBanner.SaveMainBanner(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

    }
}
