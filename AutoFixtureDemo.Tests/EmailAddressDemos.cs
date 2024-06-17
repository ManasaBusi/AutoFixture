using AutoFixture;
using DemoCode;
using System.Net.Mail;


namespace AutoFixtureDemo.Tests
{
    public class EmailAddressDemos
    {
        [Fact]
        public void Email()
        {
            //Arrange
            var fixture = new Fixture();

            //string localPart = fixture.Create<EmailAddressLocalPart>().LocalPart;
            //string domain = fixture.Create<DomainName>().Domain;
            //string fullAddress = $"{localPart}@{domain}";

            //MailAddress email = fixture.Create<MailAddress>();
            //var sut = new EmailMessage(email.Address, fixture.Create<string>(), fixture.Create<bool>());

            var sut = new EmailMessage(fixture.Create<MailAddress>().Address, fixture.Create<string>(), fixture.Create<bool>(), fixture.Create<string>());

            // etc.

        }
    }
}
