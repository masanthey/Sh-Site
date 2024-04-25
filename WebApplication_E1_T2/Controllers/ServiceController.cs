using Microsoft.AspNetCore.Mvc;
using WebApplication_E1_T2.Domain;

namespace WebApplication_E1_T2.Controllers
{
	public class ServiceController : Controller
	{

		private readonly DataManager _dataManager;

		public ServiceController(DataManager dataManager) {  _dataManager = dataManager; }

		public IActionResult Index(Guid id)
		{
			if (id != default)
				return View("Show", _dataManager.ServiceItems.GetServiceItemById(id));

			ViewBag.TextField = _dataManager.TextField.GetTextFieldByCodeWord("PageServices");
			return View(_dataManager.ServiceItems.GetServiceItems());
		}
	}
}
