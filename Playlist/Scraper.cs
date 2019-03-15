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
            this.Request("https://www.youtube.com/results?search_query=GTX+1660", Parse);
        }

        public override void Parse(Response response)
        {
            Console.WriteLine("scraping");
            var videos = new List<string>();
            foreach (var item in response.XPath("//a[@id='video-title']")){
                string link = item.Attributes["href"];
                videos.Add(link);
            }
            Scrape(videos, "Videos.json");
        }
    }
}
