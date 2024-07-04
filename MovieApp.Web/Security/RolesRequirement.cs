using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace MemoMate.Web.Security
{
	public class RolesRequirement : IAuthorizationRequirement
	{
		public IEnumerable<string> Roles { get; }

		public RolesRequirement(IEnumerable<string> roles)
		{
			Roles = roles;
		}
	}
}
