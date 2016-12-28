using HtmlAgilityPack;

namespace HtmlParserCSharp
{
    public class Parser
    {
        public dynamic GetPrayerTimes()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("http://www.daralnoor.org");

            var fajrAdhan = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[2]/div[2]/span").InnerHtml;
            var fajrIqaamah = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[2]/div[3]/span").InnerHtml;
            var sunrise = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[3]/div[2]/span").InnerHtml;
            var dhurhAdhan = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[4]/div[2]/span").InnerHtml;
            var dhurhIqaamah = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[4]/div[3]/span").InnerHtml; 
            var asrAdhan = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[5]/div[2]/span").InnerHtml;
            var asrIqaamah = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[5]/div[3]/span").InnerHtml; 
            var maghribAdhan = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[6]/div[2]/span").InnerHtml; 
            var maghribIqaamah = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[6]/div[3]/span").InnerHtml;
            var ishaAdhan = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[7]/div[2]/span").InnerHtml;
            var ishaIqaamah = document.DocumentNode.SelectSingleNode(@"//*[@id=""prayertimedetails-11""]/div/section/ul[1]/li[7]/div[3]/span").InnerHtml;             

            var prayerTimes = new {
                fajrAdhan = fajrAdhan, 
                fajrIqaamah = fajrIqaamah,
                dhurhAdhan = dhurhAdhan,
                dhurhIqaamah = dhurhIqaamah,
                asrAdhan = asrAdhan,
                asrIqaamah = asrIqaamah,
                maghribAdhan = maghribAdhan,
                maghribIqaamah = maghribIqaamah,
                ishaAdhan = ishaAdhan,
                ishaIqaamah = ishaIqaamah
            };

            return prayerTimes;

        }
    }
}
