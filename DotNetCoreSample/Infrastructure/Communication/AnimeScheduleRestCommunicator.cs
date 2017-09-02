using System.Net.Http;

namespace DotNetCoreSample.Infrastructure.Communication
{
    public class AnimeScheduleRestCommunicator
    {
        public object FetchAnimeSchedule()
        {
            var client = new HttpClient();
//            var response = client.GetAsync("");
            
            return "";
        }
    }
}