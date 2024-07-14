using System.Collections.Generic;

namespace MemoMate.Web.Models.Search
{
    public class SearchModel
    {
        public List<SearchItemModel> FoundUsers { get; set; }
        public List<SearchItemModel> FoundPosts { get; set; }
        public List<SearchItemModel> FoundThemes { get; set; }
	}
}
