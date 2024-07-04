using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace MemoMate.Web.Security
{
	public class RolesAuthorizationHandler : AuthorizationHandler<RolesRequirement>
	{
		protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RolesRequirement requirement)
		{
			if (requirement.Roles.Any(role => context.User.IsInRole(role)))
			{
				context.Succeed(requirement);
			}

			return Task.CompletedTask;
		}
	}
}
