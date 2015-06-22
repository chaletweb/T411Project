using System;
using System.Net;

namespace T411.Core
{
    public class WebRequestCreate : IWebRequestCreate
    {
        public WebRequest Create(Uri uri)
        {
            return System.Net.WebRequest.Create(uri);
        }
    }
}