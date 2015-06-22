using System;
using NUnit.Framework;
using T411.Core;
using System.Linq;

namespace T411.Core.Test
{
	[TestFixture ()]
	public class ApiConnectorTest
	{
		private IApiConnector api;
		private IApiConnector apiError;

		[SetUp ()]
		public void Setup()
		{
			IAuthorization auth = new Authorization ();
			auth.Token = "7827821:168:3fab3eb05a3cbf1f120607cf2a5656a5";
			api = new ApiConnector (auth);

			IAuthorization authError = new Authorization ();
			authError.Token = "0000000:111:0fab1eb22a3cbf4f155555cf6a7777a8";
			apiError = new ApiConnector (authError);
		}

		[Test ()]
		public void ShouldReturnListWithTop100()
		{
			var top100 = api.Search(SearchTop.Top100);
			Assert.AreEqual (100, top100.Torrents.Length);
		}

		[Test ()]
		public void ShouldReturnErrorListWithTop100WithWrongToken()
		{
			var top100 = apiError.Search(SearchTop.Top100);
			Assert.IsTrue (top100.Code == 101);
		}

		[Test ()]
		public void ShouldReturnListWithAvatarSearch()
		{
			var avatarSearch = api.SearchQuery("avatar");
			Assert.IsTrue (avatarSearch.Torrents.Length > 0);
		}

		[Test ()]
		public void ShouldReturnErrorWithWrongToken()
		{
			var avatarSearch = apiError.SearchQuery("avatar");
			Assert.IsTrue (avatarSearch.Code == 101);
		}

		[Test ()]
		public void ShouldReturnListWithTopToday()
		{
			var top = api.Search(SearchTop.TopToday);
			Assert.AreEqual (top.Torrents.Length, top.Torrents.ToList().Count(x=>x.Added >= DateTime.Now.AddDays(-1)));
		}

		[Test ()]
		public void ShouldReturnListWithTopMonth()
		{
			var top = api.Search(SearchTop.TopMonth);
			Assert.AreEqual (top.Torrents.Length, top.Torrents.ToList().Count(x=>x.Added >= DateTime.Now.AddDays(-31)));
		}

		[Test ()]
		public void ShouldReturnListWithTopWeek()
		{
			var top = api.Search(SearchTop.TopWeek);
			Assert.AreEqual (top.Torrents.Length, top.Torrents.ToList().Count(x=>x.Added >= DateTime.Now.AddDays(-7)));
		}

		[Test ()]
		public void ShouldReturnDetail()
		{
			var tor = api.Detail(50096);
			Assert.AreEqual (0, tor.Code);
		}

		[Test ()]
		public void ShouldReturnErrorForWrongIdDetail()
		{
			var tor = api.Detail(-9009601);
			Assert.AreEqual (301, tor.Code);
		}
	}
}

