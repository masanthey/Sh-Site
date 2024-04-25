using Microsoft.EntityFrameworkCore;
using WebApplication_E1_T2.Domain.Entities;
using WebApplication_E1_T2.Domain.Repositories.Interfaces;

namespace WebApplication_E1_T2.Domain.Repositories.EntityFramework
{
    public class EFMainBannerRepository: IMainBannerRepository
    {
        private readonly AppDbContext context;
        public EFMainBannerRepository(AppDbContext _context) 
        { 
            context = _context; 
        }

        public IQueryable<MainBanner> GetMainBanner() 
        {
            return context.MainBanner;
        }
        public void SaveMainBanner(MainBanner entity) 
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteMainBanner(Guid id)
        {
            context.MainBanner.Remove(new MainBanner() { Id = id });
            context.SaveChanges();
        }

        public MainBanner GetMainBannerById(Guid id)
        {
            return context.MainBanner.FirstOrDefault(x => x.Id == id);
        }

        public MainBanner GetFirstMainBanner()
        {
            return context.MainBanner.First();
        }



    }
}
