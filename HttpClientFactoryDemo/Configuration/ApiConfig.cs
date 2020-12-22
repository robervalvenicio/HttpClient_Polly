using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Configuration
{

    public interface IApiConfig
    {
        public string BaseUrl { get; set; }
    }

    public class ApiConfig : IApiConfig
    {
        public string BaseUrl  { get; set; }
    }
}
