﻿using MagicShilla_Utility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicShilla_Utility.Dto
{
    public class LoginResponseDto
    {
        public LocalUserDto User { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
