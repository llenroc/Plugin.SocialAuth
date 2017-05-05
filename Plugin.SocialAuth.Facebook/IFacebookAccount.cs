using System;
using System.Collections.Generic;

namespace Plugin.SocialAuth.Facebook
{
	public interface IFacebookAccount : IAccount
	{
		string ApplicationId { get; set; }
		string UserId { get; set; }

		string FirstName { get; set; }
		string MiddleName { get; set; }
		string LastName { get; set; }

		IEnumerable<string> DeclinedPermissions { get; set; }
		IEnumerable<string> Permissions { get; set; }

		Uri LinkUri { get; set; }
		Uri PhotoUri { get; set; }
	}
}