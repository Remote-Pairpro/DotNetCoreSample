using Xunit;
using DotNetCoreSample.Infrastructure.Communication;

namespace DotNetCoreSampleTest.Infrastructure.Communication
{
    public class AnimesScheduleRestCommunicatorTest
    {
        [Fact]
        public void サイトnhkからrestでアニメ情報を取ってくる()
        {
            var sut = new AnimeScheduleRestCommunicator();
            var actual = sut.FetchAnimeSchedule();
            Assert.NotNull(actual);
        }
    }
}