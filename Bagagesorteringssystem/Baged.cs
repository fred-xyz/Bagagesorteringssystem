using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    public class Baged
    {

        private string name; //name for the baged owner
        private int bagedNumber;
        private int passengerNumber;
        private int flightNumber;
        private int waget;
        private DateTime timeChackIn;
        private DateTime timeGate;
        private DateTime flightTime;
        private string toGate;

        public string Name { get => name; set => name = value; }
        public int BagedNumber { get => bagedNumber; set => bagedNumber = value; }
        public int PassengerNumber { get => passengerNumber; set => passengerNumber = value; }
        public int FlightNumber { get => flightNumber; set => flightNumber = value; }
        public int Waget { get => waget; set => waget = value; }
        public DateTime TimeChackIn { get => timeChackIn; set => timeChackIn = value; }
        public DateTime TimeGate { get => timeGate; set => timeGate = value; }
        public DateTime FlightTime { get => flightTime; set => flightTime = value; }
        public string ToGate { get => toGate; set => toGate = value; }

        public Baged(string name, int bagedNumber, int passengerNumber, int flightNumber, int waget, DateTime TimeChackIn, DateTime timeGate, DateTime flightTime, string toGate)
        {
            this.Name = name;
            this.BagedNumber = bagedNumber;
            this.PassengerNumber = passengerNumber;
            this.FlightNumber = flightNumber;
            this.Waget = waget;
            this.TimeChackIn = flightTime;
            this.TimeGate = timeGate;
            this.ToGate = toGate;
        }
    }
}
