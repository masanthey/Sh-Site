using WebApplication_E1_T2.Domain.Entities;

namespace WebApplication_E1_T2.Domain.Repositories.Interfaces
{
	public interface ITextFieldsRepository
	{
		IQueryable<TextField> GetTextFields();
		TextField GetTextFieldById(Guid id);
		TextField GetTextFieldByCodeWord(string codeWord);
		void SaveTextField(TextField entity);
		void DeleteTextField(Guid id);
	}
}
