using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class DateAndTimeDemos
    {
        [Fact]
        public void DateTimes()
        {
            //Arrange
            var fixture = new Fixture();
            //DateTime logTime = new DateTime(2020, 1, 21);
            DateTime logTime = fixture.Create<DateTime>();

            //Act
            LogMessage result = LogMessageCreator.Create(fixture.Create<string>(), logTime);

            //Assert
            //Assert.Equal(2020, result.Year);
            Assert.Equal(logTime.Year, result.Year);
        }

        [Fact]

        public void TimeSpans()
        {
            //Arrange
            var fixture = new Fixture();

            TimeSpan timeSpan = fixture.Create<TimeSpan>();

            //Etc.
        }   
    }
}
