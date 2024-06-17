using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using AutoFixtureDemo.Tests;
using Moq;
using Xunit;

namespace DemoCode.Tests
{
    public class EmailMessageBufferShould
    {
        //[Fact]
        //public void AddMessageToBuffer()
        //{
        //    var fixture = new Fixture();
        //    //var sut = new EmailMessageBuffer();

        //    //var message = new EmailMessage("sarah@dontcodetired.com",
        //    //                               "Hi, hope you are good today, Jason",
        //    //                               true, "Test Subject");

        //    sut.Add(fixture.Create<EmailMessage>());

        //    //sut.Add(message);

        //    Assert.Equal(1, sut.UnsentMessagesCount);
        //}


        //[Fact]
        //public void RemoveMessageFromBufferWhenSent()
        //{
        //    var fixture = new Fixture();
        //    var sut = new EmailMessageBuffer();

        //    //var message = new EmailMessage("sarah@dontcodetired.com",
        //    //                               "Hi, hope you are good today, Jason",
        //    //                               true, "Test Subject");

        //    sut.Add(fixture.Create<EmailMessage>());
        //    //sut.Add(message);


        //    sut.SendAll();

        //    Assert.Equal(0, sut.UnsentMessagesCount);
        //}


        //[Fact]
        //public void SendOnlySpecifiedNumberOfMessages()
        //{
        //var fixture = new Fixture();
        //var sut = new EmailMessageBuffer();

        //var message1 = new EmailMessage("sarah001@dontcodetired.com",
        //                               "Hi, hope you are good today, Jason",
        //                               true, "Test Subject");


        //var message2 = new EmailMessage("sarah002@dontcodetired.com",
        //                                "Hi, hope you are good today, Jason",
        //                                true, "Test Subject");

        //var message3 = new EmailMessage("sarah003@dontcodetired.com",
        //                                "Hi, hope you are good today, Jason",
        //                                true, "Test Subject");

        //    sut.Add(fixture.Create<EmailMessage>());
        //    sut.Add(fixture.Create<EmailMessage>());
        //    sut.Add(fixture.Create<EmailMessage>());

        //    //sut.Add(message1);
        //    //sut.Add(message2);
        //    //sut.Add(message3);

        //    sut.SendLimited(2);

        //    Assert.Equal(1, sut.UnsentMessagesCount);
        //}

        [Fact]
        public void SendEmailToGateway_Manual_Moq()
        {
            var fixture = new Fixture();

            var mockGateway = new Moq.Mock<IEmailGateway>();

            var sut = new EmailMessageBuffer(mockGateway.Object);

            sut.Add(fixture.Create<EmailMessage>());

            //Act

            sut.SendAll();

            //Assert
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());

        }

        //[Fact]
        [Theory]
        [AutoMoqData]
        public void SendEmailToGateway_Moq(EmailMessage message, [Frozen] Mock<IEmailGateway> mockGateway, EmailMessageBuffer sut)
        {
            //var fixture = new Fixture();
            //fixture.Customize(new AutoMoqCustomization());
            //var mockGateway = fixture.Freeze<Mock<IEmailGateway>>();

            //var sut = fixture.Create<EmailMessageBuffer>();

            //sut.Add(fixture.Create<EmailMessage>());

            //Arrange
            sut.Add(message);

            //Act
            sut.SendAll();

            //Assert
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());
        }
    }
}
