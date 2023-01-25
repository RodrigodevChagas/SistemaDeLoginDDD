﻿using System.ComponentModel.DataAnnotations;

namespace SistemaDeLogin.Data.Requests
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Please, type your username!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please, type your password!")]
        public string? Password { get; set; }
    }
}
