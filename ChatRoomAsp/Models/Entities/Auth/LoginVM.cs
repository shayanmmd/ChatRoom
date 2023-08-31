using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Models.Entities.Auth
{
    public class LoginVM
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }
    }
}
