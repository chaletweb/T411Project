using NUnit.Framework;

namespace T411.Api.UnitTest
{
    public class WrapperTest
    {
        [Test]
        public void AuthTest()
        {
            ApiConnector wrapper = new ApiConnector();
        }

        [Test]
        public void SearchTest()
        {
            ApiConnector wrapper = new ApiConnector();
            var list = wrapper.Search("x-men");
        }

        [Test]
        public void DownloadTorrent()
        {
            ApiConnector wrapper = new ApiConnector();
            wrapper.Download("4559101");
        }
    }
}
