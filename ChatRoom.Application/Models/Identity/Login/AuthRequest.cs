using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Models.Identity.Login
{
    public class AuthRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
