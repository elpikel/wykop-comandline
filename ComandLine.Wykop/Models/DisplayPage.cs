using System.Collections.Generic;

namespace ComandLine.Wykop.Models
{
    public class DisplayPage
    {
        public List<Header> Headers { get; set; }
        public int CurrentPage { get; set; }

        public bool NeedNewOnes
        {
            get { return ((CurrentPage + 1) * 10) > Headers.Count; }
        }

        public string DisplayContent()
        {
            var content = "";

            for (int i = 0; i < 10; i++)
            {
                content += string.Format("{0}: {1}\n", i, Headers[i + 10 * CurrentPage].Text);
            }

            return content + "10: Display More\n";
        }

        public Header GetHeader(int linkNumber)
        {
            return Headers[CurrentPage * 10 + linkNumber];
        }
    }
}