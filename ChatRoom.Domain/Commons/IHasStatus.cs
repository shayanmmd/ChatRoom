﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Domain.Commons
{
    public interface IHasStatus
    {
        public bool Status { get; set; }
    }
}