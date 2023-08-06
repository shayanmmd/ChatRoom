using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Application.Models.Email
{
    public class EmailSetting
    {
        public static string FromAddress { get; set; }
        public static string FromName { get; set; }
        public static string ApiKey { get; set; }
    }
}
