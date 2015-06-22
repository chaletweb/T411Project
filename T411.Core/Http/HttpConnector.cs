
using System;
using System.Collections.Specialized;
using System.Text;

namespace T411.Core
{
    public class HttpConnector : IHttpConnector
    {
        private readonly IWebClientWrapper webClient;

        public HttpConnector() : this(new WebClientWrapper())
        {
            
        }

        public HttpConnector(IWebClientWrapper webClient)
        {
            this.webClient = webClient;
        }

        public string Token
        {
            get 
            {return webClient.GetHeader("Authorization");}
            set
            {webClient.AddHeader("Authorization", value);}
            
        }

        public byte[] HttpGet(string uri)
        {
            return webClient.DownloadString(uri);
        }

        public string HttpGetString(string uri)
        {
            var response = webClient.DownloadString(uri);
            return Encoding.UTF8.GetString(response);
        }

        public string HttpPost(string uri, NameValueCollection parameterCollection)
        {
            return webClient.UploadValues(uri, "POST", parameterCollection);
        }

        public string HttpPost(string uri, string username, string password)
        {
            var parameters = new NameValueCollection {{"username", username}, {"password", password}};
            return HttpPost(uri, parameters);
        }
    }
}
