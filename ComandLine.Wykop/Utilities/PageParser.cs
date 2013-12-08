using System.Collections.Generic;
using System.Web;
using ComandLine.Wykop.Models;
using HtmlAgilityPack;

namespace ComandLine.Wykop.Utilities
{
    public class PageParser
    {
        private readonly HtmlDocument _page;

        public PageParser(string html)
        {
            _page = new HtmlDocument();
            _page.LoadHtml(html);
        }

        public List<Header> GetHeaders()
        {
            var htmlHeaders = _page.DocumentNode.SelectNodes("//header//h2//a[@href]");
            var headers = new List<Header>();

            foreach (var htmlHeader in htmlHeaders)
            {
                if (!htmlHeader.Attributes["href"].Value.Contains("paylink"))
                {
                    headers.Add(new Header
                        {
                            LinkToArticle = htmlHeader.Attributes["href"].Value,
                            Text = HttpUtility.HtmlDecode(htmlHeader.InnerText)
                        });
                }
            }

            return headers;
        }
    }
}