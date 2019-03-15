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
        public override void Init()
        {
            License.LicenseKey = "LicenseKey";
            this.LoggingLevel = WebScraper.LogLevel.All;
            //this.ObeyRobotsDotTxt = false;
            this.Request("https://www.amazon.com.mx/s?k=ready+player+one", Parse);
        }

        public override void Parse(Response response)
        {
            Console.WriteLine("scraping");
            var videos = new List<string>();
            foreach (var item in response.XPath("//div[@class='a-section aok-relative s-image-fixed-height']/img[@class='s-image']")){
                string link = item.ChildNodes[0].Attributes["src"];
                Console.WriteLine(link);
                videos.Add(link);
            }
            Scrape(videos, "Videos.json");
        }
    }
}
