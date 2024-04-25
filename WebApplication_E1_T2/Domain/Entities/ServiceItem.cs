using System.ComponentModel.DataAnnotations;

namespace WebApplication_E1_T2.Domain.Entities
{
	public class ServiceItem : EntityBase
	{
		[Required(ErrorMessage = "Это обязательное поле")]
		[Display(Name = "Название услуги")]
		public override string Title { get; set; }

		[Display(Name = "Краткое описание услуги")]
		public override string SubTitle { get; set; }

		[Display(Name = "Полное описание услуги")]
		public override string Text { get; set; }

	//	[Display(Name = "Цена услуги")]
		//public override string Price { get; set; }
	}
}
