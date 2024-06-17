using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class GuidEnumDemos
    {
        [Fact]
        public void Guid()
        {
            //Arrange
            var fixture = new Fixture();
            var sut = new EmailMessage(fixture.Create<string>(), fixture.Create<string>(), fixture.Create<bool>(), fixture.Create<string>());

            //sut.Id = fixture.Create<Guid>();

            //Etc.
        }

        [Fact]

        public void Enum()
        {
            //Arrange
            var fixture = new Fixture();

           var sut = new EmailMessage(fixture.Create<string>(), fixture.Create<string>(), fixture.Create<bool>(), fixture.Create<string>());

            //sut.Id = fixture.Create<Guid>();

            //sut.MessageType = fixture.Create<EmailMessageType>();

            // etc.
        }
    }
}
