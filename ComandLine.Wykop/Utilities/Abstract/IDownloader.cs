using ComandLine.Wykop.Models;

namespace ComandLine.Wykop.Utilities.Abstract
{
    public interface IDownloader
    {
        string Download(IDownloadable resource);
    }
}