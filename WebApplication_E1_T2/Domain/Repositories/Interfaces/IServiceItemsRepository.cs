using WebApplication_E1_T2.Domain.Entities;

namespace WebApplication_E1_T2.Domain.Repositories.Interfaces
{
	public interface IServiceItemsRepository
	{
		IQueryable<ServiceItem> GetServiceItems();
		ServiceItem GetServiceItemById(Guid id);
		void SaveServiceItem(ServiceItem entity);
		void DeleteServiceItem(Guid id);
	}
}
