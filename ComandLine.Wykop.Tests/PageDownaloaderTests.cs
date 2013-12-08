using ComandLine.Wykop.Models;
using ComandLine.Wykop.Utilities;
using NUnit.Framework;

namespace ComandLine.Wykop.Tests
{
    [TestFixture]
    public class PageDownaloaderTests
    {
        [Test]
        public void ShouldReturnMainPageHtml()
        {
            var page = new Page("http://www.wykop.pl/strona/");
            var downloader = new PageDownloader();
            string downloadedPage = downloader.Download(page);

            Assert.IsNotEmpty(downloadedPage);
        }
    }
}