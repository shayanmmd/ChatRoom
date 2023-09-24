using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Models.Identity.Login
{
    public class AuthResponse
    {
        public Guid Guid { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Succussed { get; set; } = true;
        public string ErrorMessage { get; set; }
    }
}
