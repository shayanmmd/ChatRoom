﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Models.Identity.Login
{
    public class AuthRequest
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}