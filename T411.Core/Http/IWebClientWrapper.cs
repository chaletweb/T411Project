using System.Collections.Specialized;

namespace T411.Core
{
    public interface IWebClientWrapper
    {
        void AddHeader(string name, string value);
        byte[] DownloadString(string uri);
        string UploadValues(string uri, string method, NameValueCollection data);
        string GetHeader(string name);
    }
}