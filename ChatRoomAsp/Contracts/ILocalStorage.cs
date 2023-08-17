using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomAsp.Contracts
{
    public interface ILocalStorage
    {
        void ClearStorage(List<string> keys);
        bool Exits(string key);
        T GetStorageValue<T>(string key);
        void SetStorageValue<T>(string key,T value);
    }
}
