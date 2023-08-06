﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Models.Email
{
    public class Email
    {
        public string To { get; set; }
        public string FromAddress{ get; set; }
        public string FromName{ get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }
}
