using System.Threading.Tasks;
using MemoMate.Web.Models;
namespace MemoMate.Web.Interfaces
{
	public interface ISidebarService
	{
		Task<SidebarModel> GetSidebarModelAsync(User user);
	}
}
