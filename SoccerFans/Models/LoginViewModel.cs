﻿using System.ComponentModel.DataAnnotations;

namespace FootyFans.Models
{
	public class LoginViewModel
	{
        [Required]
        [UIHint("email")]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
