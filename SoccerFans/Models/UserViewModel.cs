﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FootyFans.Models
{
	public class CreateModel
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}

	public class UserRoleEditModel
	{
		public IdentityRole Role { get; set; }
		public IEnumerable<AppUser> Members { get; set; }
		public IEnumerable<AppUser> NonMembers { get; set; }
	}

	public class RoleModificationModel
	{
		[Required]
		public string RoleName { get; set; }
		public string RoleId { get; set; }
		public string[] IdsToAdd { get; set; }
		public string[] IdsToDelete { get; set; }
	}
}
