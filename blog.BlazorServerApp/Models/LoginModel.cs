﻿namespace blog.BlazorServerApp.Models
{
    public class LoginModel
    {
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required, MinLength(5)]
        public string Password { get; set; }
    }
}
