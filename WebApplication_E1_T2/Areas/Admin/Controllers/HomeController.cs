using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_E1_T2.Domain;
using WebApplication_E1_T2.Domain.Entities;
using WebApplication_E1_T2.Domain.Repositories.EntityFramework;
using WebApplication_E1_T2.Models;

namespace WebApplication_E1_T2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager) 
        { 
            this.dataManager = dataManager;
        }
        public HomeContentViewModel Model { get; set; } = new HomeContentViewModel();


            
        public ActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
