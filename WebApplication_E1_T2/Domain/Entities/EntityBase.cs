using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Web;

namespace WebApplication_E1_T2.Domain.Entities
{
    public abstract class EntityBase
	{
		protected EntityBase() => DateAdded = DateTime.UtcNow;

		[Required]
		public Guid Id { get; set; }

		[Display(Name = "Название (заголовок)")]
		public virtual string Title { get; set; } = "default";

		[Display(Name = "Краткое описание")]
		public virtual string SubTitle { get; set; } = "default";

		[Display(Name = "Полное описание")]
		public virtual string Text { get; set; } = "default";

		[Display(Name = "Титульная картинка")] 
		public virtual string TitleImagePath { get; set; } = "default";

		[Display(Name = "SEO метатег Title")]
		public string MetaTitle { get; set; } = "default";

		[Display(Name = "SEO метатег Description")]
		public string MetaDescription { get; set; } = "default";

		[Display(Name = "SEO метатег Keywords")]
		public string MetaKeywords { get; set; } = "default";

		[DataType(DataType.Time)]
		public DateTime DateAdded { get; set; }

	}
}