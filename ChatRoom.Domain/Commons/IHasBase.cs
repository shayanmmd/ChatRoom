using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom.Domain.Commons
{
    public interface IHasBase : IHasGuid, IHasModified, IHasStatus
    {
    }
}
