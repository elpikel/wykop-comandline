using System;
using ComandLine.Wykop.Models;
using ComandLine.Wykop.Utilities;

namespace ComandLine.Wykop
{
    class Program
    {
        static void Main()
        {
            var page = new Page("http://www.wykop.pl/strona/");
            var downloader = new PageDownloader();
            string downloadedPage = downloader.Download(page);
            var pageParser = new PageParser(downloadedPage);

            var displayPage = new DisplayPage() { Headers = pageParser.GetHeaders(), CurrentPage = 0 };
            Console.Write(displayPage.DisplayContent());

            var command = Console.ReadLine();
            while (command != null)
            {
                if (int.Parse(command) == 10)
                {
                    displayPage.CurrentPage++;
                    if(displayPage.NeedNewOnes)
                    {
                        page.Number++;
                        downloadedPage = downloader.Download(page);
                        pageParser = new PageParser(downloadedPage);
                        displayPage.Headers.AddRange(pageParser.GetHeaders());
                    }
                    Console.Write(displayPage.DisplayContent());
                }
                else
                {
                    var linkNumber = int.Parse(command);
                    Header header = displayPage.GetHeader(linkNumber);
                    Console.WriteLine(header.LinkToArticle);
                }
                command = Console.ReadLine();
            }
        }
    }
}
