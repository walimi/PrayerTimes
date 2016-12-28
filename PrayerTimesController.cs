using HtmlParserCSharp;
using System.Web.Http;

namespace PrayerTimes.Controllers
{
    public class PrayerTimesController : ApiController
    {
        [HttpGet, Route("api/prayer")]
        public dynamic GetPrayerTimes() {

            var htmlParser = new Parser();
            dynamic prayerTimes = htmlParser.GetPrayerTimes();
            return prayerTimes;
        }
    }
}
