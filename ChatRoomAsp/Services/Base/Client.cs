using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChatRoomAsp.Services.Base
{
    public partial class Client : IClient
    {
        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
    }
}
