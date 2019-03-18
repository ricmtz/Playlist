using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class CtrlScraper
    {
        private Scraper scraper;

        public CtrlScraper()
        {
            scraper = new Scraper();
        }

        public List<String> GetResulsts()
        {
            Console.WriteLine("Geting results");
            List<string> auxResult = new List<string>();
            if(Scraper.results.Count > 0)
            {   
                auxResult.Add(Scraper.results[0]);
                auxResult.Add(Scraper.results[1]);
                auxResult.Add(Scraper.results[2]);
            }
            foreach(var i in auxResult)
            {
                Console.WriteLine(i);
            }
            return auxResult;
        }

        public async void Search(string search, Func<bool> fn)
        {
            Scraper.SearchString = search;
            Console.WriteLine(Scraper.SearchString);
            await scraper.StartAsync();
            fn();
        }

    }
}
