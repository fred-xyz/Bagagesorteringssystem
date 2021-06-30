using System;
using System.Collections.Generic;
using System.Threading;

namespace Bagagesorteringssystem
{
    class Program
    {
        //class Sort
        public static List<Baged> SortList = new List<Baged>();
        public static List<Baged> bagedSort = new List<Baged>();

        //class ChackIn
        public static List<Baged> BagedList = new List<Baged>();
        public static List<Baged> bagedCheckedIn = new List<Baged>(); // take from her and add to bagedSort


        public static List<Flight> ListOfFlight = new List<Flight>();
        



        static void Main(string[] args)
        {
            //lists of aircraft
            ListOfFlight.Add(new Flight(001, DateTime.Now.AddHours(1), "gate_1"));
            ListOfFlight.Add(new Flight(002, DateTime.Now.AddMinutes(36), "gate_2"));
            ListOfFlight.Add(new Flight(003, DateTime.Now.AddMinutes(4), "gate_3"));

            //list af Baged der skal med flyvet
            //name, bagedNumber, passengerNumber, flightNumber, waget, TimeChackIn, timeGate, flightTime
            BagedList.Add(new Baged("fredd", 222, 222, 001, 22, DateTime.Now.AddYears(500), DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), "now gate"));
            BagedList.Add(new Baged("bob", 223, 223, 001, 23, DateTime.Now.AddYears(500), DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), "now gate"));
            BagedList.Add(new Baged("matin", 224, 224, 002, 24, DateTime.Now.AddYears(500), DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), "now gate"));
            BagedList.Add(new Baged("tohams", 225, 225, 003, 25, DateTime.Now.AddYears(500), DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), "now gate"));
            BagedList.Add(new Baged("patrig", 226, 226, 002, 26, DateTime.Now.AddYears(500), DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), "now gate"));


            Thread chackIn = new Thread(ChackIn.HandelBagged);
            Thread sort = new Thread(Sort.HandelSorting);
            chackIn.Start();
            sort.Start();


        }

        
    }
}
