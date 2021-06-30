using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    class Flight
    {
        //Number
        private int flightNumber;
        //Departure
        private DateTime departureTime;
        //Gate
        private string gate;

        public int FlightNumber { get => flightNumber; set => flightNumber = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
        public string Gate { get => gate; set => gate = value; }

        public Flight(int flightNumber, DateTime departureTime, string gate)
        {
            this.FlightNumber = flightNumber;
            this.DepartureTime = departureTime;
            this.Gate = gate;
        }
    }
}
