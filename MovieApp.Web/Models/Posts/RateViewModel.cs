namespace MemoMate.Web.Models.Posts
{
    public class RateViewModel
    {
        public UserEntity LoggedUserEntity { get; set; }
        public PostDetailModel RatePost { get; set; }
        public bool like { get; set; }
    }
}
