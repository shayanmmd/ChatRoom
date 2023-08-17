using ChatRoomAsp.Contracts;
using Hanssens.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ILocalStorage = ChatRoomAsp.Contracts.ILocalStorage;

namespace ChatRoomAsp.Services
{
    public class LocalStorageService : ILocalStorage
    {

        LocalStorage _storage;
        public LocalStorageService()
        {
            var configuration = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "ChatRoom",
            };
            _storage = new LocalStorage(configuration);
        }


        public void ClearStorage(List<string> keys)
        {
            foreach (var item in keys)
                _storage.Clear();
        }

        public bool Exits(string key)
        {
            if (_storage.Exists(key)) return true;
            return false;
        }

        public T GetStorageValue<T>(string key)
        {
            return _storage.Get<T>(key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _storage.Store(key, value);
            _storage.Persist();
        }
    }
}
