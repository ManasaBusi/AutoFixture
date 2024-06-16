using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class CustomizationDemos
    {
        [Fact]
        public void DateTimeCustomization()
        {
            //Arrange
            var fixture = new Fixture();

            //fixture.Customize(new CurrentDateTimeCustomization());
            fixture.Customizations.Add(new CurrentDateTimeGenerator());

            var date1 = fixture.Create<DateTime>();
            var date2 = fixture.Create<DateTime>();

            //Act
        }

        [Fact]
        public void CustomizedPipeline()
        {
            //Arrange
            var fixture = new Fixture();

            fixture.Customizations.Add(new AirportCodeStringPropertyGenerator());

            var flight = fixture.Create<FlightDetails>();
            var airportCode = fixture.Create<Airport>();

            // etc.
        }
    }
}
