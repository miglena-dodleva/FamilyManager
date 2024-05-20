﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FamilyManager.ViewModels.Home
{
    public class LoginVM
    {
        [DisplayName("Username: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Username { get; set; }

        [DisplayName("Password: ")]
        [Required(ErrorMessage = "*This field is Required!")]
        public string Password { get; set; }
    }
}
