﻿using System.ComponentModel.DataAnnotations;

namespace GalaxyFlow.Web.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
