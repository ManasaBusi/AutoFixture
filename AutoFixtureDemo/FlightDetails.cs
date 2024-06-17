using AutoFixtureDemo;
using System;

namespace DemoCode
{
    public class FlightDetails
    {
        public FlightDetails(AirportCode departureAirportCode, AirportCode arrivalAirportCode)
        {
            //EnsureValidAirportCode(departureAirportCode);
            //EnsureValidAirportCode(arrivalAirportCode);

            DepartureAirportCode = departureAirportCode;
            ArrivalAirportCode = arrivalAirportCode;
        }

        public AirportCode DepartureAirportCode { get; }
        public AirportCode ArrivalAirportCode { get; }        
        public TimeSpan FlightDuration { get; set; }
        public string AirlineName { get; set; }

        //private void EnsureValidAirportCode(string airportCode)
        //{
        //    var isWrongLength = airportCode.Length != 3;

        //    var isWrongCase = airportCode != airportCode.ToUpperInvariant();

        //    if (isWrongLength || isWrongCase)
        //    {
        //        throw new Exception(airportCode + " is an invalid airport");
        //    }
        //}
    }
}