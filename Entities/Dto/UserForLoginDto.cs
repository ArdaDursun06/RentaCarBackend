﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
