using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChatRoomAsp.Services.Base
{
    public partial class Client : IClient
    {
        private readonly IConfiguration _configuration;

        public Client(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = _configuration.GetSection("ApiAddress").Value; }
        }

    }
}
