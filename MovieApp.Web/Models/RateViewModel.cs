using System.Collections.Generic;

namespace MemoMate.Web.Models
{
	public class RateViewModel
	{
		public User LoggedUserEntity { get; set; }
		public PostDetailModel RatePost { get; set; }
		public bool like { get; set; }
	}
}
