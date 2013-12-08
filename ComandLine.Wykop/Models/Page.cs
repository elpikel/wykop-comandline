namespace ComandLine.Wykop.Models
{
    public class Page : IDownloadable
    {
        private readonly string _url;

        public string Url { get { return _url + Number; } }
        public int Number { get; set; }

        public Page(string url)
        {
            _url = url;
            Number = 1;
        }
    }

    public interface IDownloadable
    {
        string Url { get; }
    }
}