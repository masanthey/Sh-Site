using System.ComponentModel.DataAnnotations;

namespace WebApplication_E1_T2.Domain.Entities
{
    public class MainBanner : EntityBase
    {
            [Required(ErrorMessage = "Это обязательное поле")]
            [Display(Name = "Заголовок баннера")]
            public override string Title { get; set; }

            [Display(Name = "Краткое описание ")]
            public override string SubTitle { get; set; }
        
    }
}
