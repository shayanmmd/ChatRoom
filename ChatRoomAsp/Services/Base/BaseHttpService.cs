using ChatRoomAsp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ChatRoomAsp.Services.Base
{
    public class BaseHttpService
    {
        private readonly IClient _client;
        private readonly ILocalStorage _localStorage;

        public BaseHttpService(IClient client,ILocalStorage localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

        protected void AddBearertoken()
        {
            if (_localStorage.Exits("token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _localStorage.GetStorageValue<string>("token"));
            }
        }
    }
}
