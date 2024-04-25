using Microsoft.AspNetCore.Mvc;
using WebApplication_E1_T2.Domain;
using WebApplication_E1_T2.Models;

namespace WebApplication_E1_T2.Controllers
{
	public class HomeController : Controller
	{
		private readonly DataManager _dataManager;

		public HomeController(DataManager dataManager) 
		{
			_dataManager = dataManager;
		}
        public IActionResult Index()
		{
            HomeContentViewModel model = new();
			model.textField = _dataManager.TextField.GetTextFieldByCodeWord("PageIndex");
			model.mainBanner = _dataManager.MainBanner.GetFirstMainBanner();
			model.serviceItem = _dataManager.ServiceItems.GetServiceItems();

            return View(model); ; 			               
		}

		public IActionResult Contacts()
		{
            HomeContentViewModel model = new();
            model.textField = _dataManager.TextField.GetTextFieldByCodeWord("PageContacts");
            model.mainBanner = _dataManager.MainBanner.GetFirstMainBanner();
            model.serviceItem = _dataManager.ServiceItems.GetServiceItems();

            return View(model);
		}

	}
}
