using System.Collections.Specialized;

namespace T411.Core
{
    public interface IHttpConnector
    {
        byte[] HttpGet(string uri);
        string HttpGetString(string uri);
        string HttpPost(string uri, NameValueCollection parameterCollection);
        string HttpPost(string uri, string username, string password);
        string Token { get; set; }
    }
}