using ChatRoom.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Domain
{
    public class GroupName : IHasBase
    {
        [Key]public Guid Guid { get; set; }
        public string Name { get; set; }
        public DateTime Modified { get; set; }
        public bool Status { get; set; }
    }
}
