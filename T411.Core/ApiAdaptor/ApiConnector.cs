using System.Collections.Generic;
using System.Text;

namespace T411.Core
{
	public enum SearchTop
	{
		[StringValue("100")]
		Top100,
		[StringValue("week")]
		TopWeek,
		[StringValue("today")]
		TopToday,
		[StringValue("month")]
		TopMonth
	}

    public class ApiConnector : IApiConnector
    {
        private readonly IHttpConnector _httpConnector;

		public ApiConnector() : this(new AuthorizationFactory().GetAuthorizationFromFile("t411.token"))
        {
            
        }

        public ApiConnector(IAuthorization auth) : this(new HttpConnector())
        {
			_httpConnector.Token = auth.Token;
        }

        public ApiConnector(IHttpConnector httpConnector)
        {
            _httpConnector = httpConnector;
        }
        

		public SearchResult SearchQuery(string query)
        {
            query += "?limit=100";
            var response = _httpConnector.HttpGetString(string.Format("https://api.t411.io/torrents/search/{0}", query));
			return JsonAdapter.GetSearch (response);
        }

		public SearchResult Search(SearchTop searchTop)
		{
			var response = _httpConnector.HttpGetString(string.Format("https://api.t411.io/torrents/top/{0}", StringEnum.GetStringValue(searchTop)));
			return JsonAdapter.GetTorrents (response);
		}

		public TorrentDetails Detail(int torrentId)
		{
			var response = _httpConnector.HttpGetString(string.Format("https://api.t411.io/torrents/details/{0}", torrentId));
			return JsonAdapter.GetDetail (response);
		}
			
        public byte[] Download(string id)
        {
            var response = _httpConnector.HttpGet(string.Format("https://api.t411.io/torrents/download/{0}", id));
			return response;
        }

    }
}
