using System.Collections.Generic;

namespace T411.Core
{
    public interface IApiConnector
    {
		SearchResult SearchQuery(string query);
        byte[] Download(string id);
		SearchResult Search (SearchTop searchTop);
		TorrentDetails Detail (int torrentId);

    }
}