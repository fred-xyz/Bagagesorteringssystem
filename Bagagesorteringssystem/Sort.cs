using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bagagesorteringssystem
{
    class Sort
    {
        //GetFromChackIn()
        public static void HandelSorting()
        {
            while (true)
            {
                Baged Gatecase;
                //Baged suitcase;

                bool proceedAllowed;
                lock (Program.bagedCheckedIn)
                {
                    if (Program.bagedCheckedIn.Count == 0)
                    {
                        Monitor.Wait(Program.bagedCheckedIn);
                    }

                    Gatecase = Program.bagedCheckedIn[0];
                    Program.bagedCheckedIn.Remove(Program.bagedCheckedIn[0]);
                    Monitor.PulseAll(Program.bagedCheckedIn);
                }
                //Console.WriteLine("BagedList");
                Thread.Sleep(1000);

                //ChackTime() SetChackInTime() ChackFlightDeparture()
                if (Gatecase.FlightTime < DateTime.Now)
                {
                    //need to chack the time and then set the gate
                    for (int i = 0; i < Program.ListOfFlight.Count; i++)
                    {
                        if (Gatecase.FlightNumber == Program.ListOfFlight[i].FlightNumber)
                        {
                            Gatecase.ToGate = Program.ListOfFlight[i].Gate;
                            
                        }
                        else
                        {
                            Console.WriteLine("you suitcasedit not apen on a flit list ");
                            proceedAllowed = false;
                        }
                    }
                    proceedAllowed = true;
                }
                else
                {
                    proceedAllowed = false;
                    Console.WriteLine("you a dith not git to the gate in timen");
                }

                if (proceedAllowed)
                {
                    lock (Program.bagedSort)
                    {
                        if (Program.SortList.Count >= 50)
                        {
                            Monitor.Wait(Program.bagedSort);
                        }
                        //OffLoad()
                        Program.bagedSort.Add(Gatecase);
                        Monitor.PulseAll(Program.bagedSort);
                    }
                }
                Thread.Sleep(1000);
                //Program.bagedCheckedIn
            }
            //ChackIFlith()
            //ChackTime()
            //SetSortTime()
            //chackGateNumber()
            ////Console.WriteLine(Program.ListOfFlight[1].FlightNumber);
            //ChackFlightDeparture()
            //ChackFlightGate()
            //sendtToGate()
        }
    }
}
