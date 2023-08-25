using ChatRoom.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoomAsp.Models.Entities
{
    public class GroupNameVM
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public DateTimeOffset Modified { get; set; }

        public bool Status { get; set; }
    }
}
