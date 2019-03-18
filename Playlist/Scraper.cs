using IronWebScraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Scraper : WebScraper
    {
        public static String xpath = "//div[@class='a-section aok-relative s-image-fixed-height']/img[@class='s-image']";
        public static List<string> results = new List<string>();
        public static String SearchString { get; set; }

        public override void Init()
        {
            String url = "https://www.amazon.com.mx/s?k=" + SearchString;
            License.LicenseKey = "LicenseKey";
            this.LoggingLevel = WebScraper.LogLevel.All;
            Console.WriteLine(url);
            Console.WriteLine("starting");
            this.Request(url, Parse);
        }

        public override void Parse(Response response)
        {
            Console.WriteLine("Start scraping");
            results.Clear();
            HtmlNode[] items = response.XPath(xpath) ?? null;
            if (items != null) {
                foreach (var item in items) {
                    string link = item.ChildNodes[0].Attributes["src"];
                    results.Add(link);
                }
            }
            Scrape(results, "results.json");
            Console.WriteLine("scraping finish");
        }
    }
}
