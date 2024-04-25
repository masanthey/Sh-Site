using WebApplication_E1_T2.Domain.Entities;

namespace WebApplication_E1_T2.Domain.Repositories.Interfaces
{
    public interface IMainBannerRepository
    {
        IQueryable<MainBanner> GetMainBanner();
        MainBanner GetMainBannerById(Guid id);
        void SaveMainBanner(MainBanner entity);
        void DeleteMainBanner(Guid id);
        MainBanner GetFirstMainBanner();
    }
}
