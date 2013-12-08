using System.Net;
using ComandLine.Wykop.Models;
using ComandLine.Wykop.Utilities.Abstract;

namespace ComandLine.Wykop.Utilities
{
    public class PageDownloader : IDownloader
    {
        public string Download(IDownloadable resource)
        {
            var webClient = new WebClient { Encoding = System.Text.Encoding.UTF8 };
            return webClient.DownloadString(resource.Url);
        }
    }
}