using WebApplication_E1_T2.Domain.Entities;

namespace WebApplication_E1_T2.Models
{
    public class HomeContentViewModel
    {
        public MainBanner mainBanner { get; set; }
        public TextField textField { get; set; }
        public IQueryable<ServiceItem> serviceItem { get; set; }
    }
}
