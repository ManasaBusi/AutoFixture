using AutoFixture.Kernel;
using System.Reflection;


namespace AutoFixtureDemo.Tests
{
    public class AirportCodeStringPropertyGenerator : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            //See if we are trying to create a value for a property
            var propertyInfo = request as PropertyInfo;

            if (propertyInfo is null)
            {
                return new NoSpecimen(); //Null is a valid specimen so return NoSpecimen
            }

            //Now we know we are dealing with a property, are we creatin a value for the AirportCode?
            var isAirCodeProperty = propertyInfo.Name.Contains("AirportCode");
            var isStringProperty = propertyInfo.PropertyType == typeof(string);

            if (isAirCodeProperty && isStringProperty)
            {
                return RandomAirportCode();
            }

            return new NoSpecimen();
        }

        private string RandomAirportCode()
        {
            if (DateTime.Now.Ticks % 2 == 0)
            {
                return "LHR";
            }

            return "PER";
        }
    }
}
