﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Business.Concrete.AutoMapper.Dtos.Auth
{
    public class RegisterUserForDto
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
