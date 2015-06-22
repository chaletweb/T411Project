using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace T411.Core
{
    public class WebClientWrapper : IWebClientWrapper
    {
        public WebClient WebClient { get; set; }

        public WebClientWrapper()
        {
            WebClient = new WebClient();
        }

        public void AddHeader(string name, string value)
        {
            var nameValue = new NameValueCollection {{name, value}};
            WebClient.Headers.Add(nameValue);
        }

        public string GetHeader(string name)
        {
            return WebClient.Headers[name];
        }

        public byte[] DownloadString(string uri)
        {
            var responsebytes = WebClient.DownloadData(uri);
            return responsebytes;
        }

        public string UploadValues(string uri, string method, NameValueCollection data)
        {
            var responsebytes = WebClient.UploadValues(uri, method, data);
            return Encoding.UTF8.GetString(responsebytes);
        }


    }
}
