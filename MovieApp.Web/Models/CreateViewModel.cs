namespace MemoMate.Web.Models
{
    public class CreateViewModel
	{
		public UserEntity LoggedUserEntity { get; set; }
		public Note NewNote { get; set; }
		public string ThemeName { get; set; }

	}
}
