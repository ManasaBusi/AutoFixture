using AutoFixture;
using DemoCode;

namespace AutoFixtureDemo.Tests
{
    public class CustomizedFixtureDemos
    {
        [Fact]
        public void Error()
        {
            //Arrange
            var fixture = new Fixture();

            fixture.Inject<string>("LHR");

            var flight = fixture.Create<FlightDetails>();

        }

        //[Fact]
        //public void SettingValueForCustomType()
        //{
        //    //Arrange
        //    var fixture = new Fixture();

        //    fixture.Inject(new FlightDetails
        //    {
        //        DepartureAirportCode = "PER",
        //        ArrivalAirportCode = "LHR",
        //        FlightDuration = TimeSpan.FromHours(10),
        //        AirlineName = "Emirates"
        //    });

        //    var flight1 = fixture.Create<FlightDetails>();
        //    var flight2 = fixture.Create<FlightDetails>();

        //    // Assert
        //}

        [Fact]
        public void CustomCreationFunction()
        {
            //Arrange
            var fixture = new Fixture();

            fixture.Register<string>(() => DateTime.Now.Ticks.ToString());

            var string1 = fixture.Create<string>();
            var string2 = fixture.Create<string>();

            // etc.
        }

        [Fact]
        public void FreezingValues()
        {
            var fixture = new Fixture();

            //var id = fixture.Create<int>();
            //fixture.Inject(id);
            //var customerName = fixture.Create<string>();
            //fixture.Inject(customerName);

            //Freezes the value which replaces Create and Inject.

            var id = fixture.Freeze<int>();
            var customerName = fixture.Freeze<string>();

            var sut = fixture.Create<Order>();

            Assert.Equal(id + "-" + customerName, sut.ToString());
        }

        [Fact]
        public void OmitSettingSpecificProperties()
        {
            //Arrange
            var fixture = new Fixture();

            //"Without" is used to create an instance without some properties or exclude them.
            
            //var flight = fixture.Build<FlightDetails>()
            //                    .Without(x => x.ArrivalAirportCode)
            //                    .Without(x => x.DepartureAirportCode)
            //                    .Create();

            //This is used to build an instance with any of the properties set.

            var flight = fixture.Build<FlightDetails>()
                                .OmitAutoProperties()
                                .Create();
            //etc.
        }

        //[Fact]
        //public void CustomizedBuilding()
        //{
        //    var fixture = new Fixture();

        //    //"With" is used to set a property to a specific value.

        //    var flight = fixture.Build<FlightDetails>()
        //                        .With(x => x.ArrivalAirportCode, "LHR")
        //                        .With(x => x.DepartureAirportCode, "LAX")
        //                        .Create();
        //    //etc.
        //}

        //[Fact]
        //public void CustomizedBuildingWithActions()
        //{
        //    var fixture = new Fixture();

        //    //DO is used to perform a specific action on a specific property in the object being built.

        //    var flight = fixture.Build<FlightDetails>()
        //                       .With(x => x.ArrivalAirportCode, "LHR")
        //                       .With(x => x.DepartureAirportCode, "LAX")
        //                       .Without(x => x.MealOptions)
        //                       .Do(x => x.MealOptions.Add("Chicken"))
        //                       .Do(x => x.MealOptions.Add("Fish"))
        //                       .Create();
        //}

        //[Fact]
        //public void CustomizedBuildingForAllTypesInFixture()
        //{
        //    var fixture = new Fixture();

        //    fixture.Customize<FlightDetails>(fd =>
        //    fd.With(x => x.DepartureAirportCode, "LHR")
        //    .With(x => x.ArrivalAirportCode, "LAX")
        //    .With(x => x.AirlineName, "Emirates")
        //    .Without(x => x.MealOptions)
        //    .Do(x => x.MealOptions.Add("Chicken"))
        //    .Do(x => x.MealOptions.Add("Fish")));

        //    var flight1 = fixture.Create<FlightDetails>();
        //    var flight2 = fixture.Create<FlightDetails>();
            
        //}
    }
}
