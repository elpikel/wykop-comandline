using System.Collections.Generic;
using ComandLine.Wykop.Models;
using ComandLine.Wykop.Utilities;
using NUnit.Framework;

namespace ComandLine.Wykop.Tests
{
    [TestFixture]
    public class PageParserTests
    {
        [Test]
        public void ReturnListOfHeaders()
        {
            var page = new Page("http://www.wykop.pl/");
            var downloader = new PageDownloader();
            string downloadedPage = downloader.Download(page);
            var pageParser = new PageParser(downloadedPage);
            List<Header> headers = pageParser.GetHeaders();

            Assert.IsTrue(headers.Count > 0);
        }
    }
}