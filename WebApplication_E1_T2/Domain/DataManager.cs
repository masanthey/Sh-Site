using WebApplication_E1_T2.Domain.Repositories.Interfaces;

namespace WebApplication_E1_T2.Domain
{
	public class DataManager
	{
		public ITextFieldsRepository TextField { get; set; }
		public IServiceItemsRepository ServiceItems { get; set; }
		public IMainBannerRepository MainBanner { get; set; }
		public DataManager(ITextFieldsRepository _TextField, IServiceItemsRepository _ServiceItems, IMainBannerRepository MainBanner) 
		{ 
			this.TextField = _TextField;
			this.ServiceItems = _ServiceItems;
			this.MainBanner = MainBanner;
		}
	}
}
