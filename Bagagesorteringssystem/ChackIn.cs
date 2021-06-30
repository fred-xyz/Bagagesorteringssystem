using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
//stackoverflow.com/questions/38544094/how-to-pass-values-from-one-class-to-another-class-using-wpf
//tutlane.com/tutorial/csharp/csharp-thread-lock

namespace Bagagesorteringssystem
{
    class ChackIn
    {
        //Opden_Close

        //getBaged()
        public static void HandelBagged()
        {
            while (true)
            {
                Baged suitcase;
                bool proceedAllowed;
                lock (Program.BagedList) {
                    if (Program.BagedList.Count == 0) //chack to se if ther somthin in the list to work with
                    {
                        Monitor.Wait(Program.BagedList);
                    }
                    
                    suitcase = Program.BagedList[0];
                    Program.BagedList.Remove(Program.BagedList[0]);
                    Monitor.PulseAll(Program.BagedList);
                }
                //Console.WriteLine("BagedList");
                Thread.Sleep(1000);

                //ChackTime() SetChackInTime() ChackFlightDeparture()
                if (suitcase.FlightTime < DateTime.Now)
                {
                    suitcase.TimeChackIn = DateTime.Now;
                    proceedAllowed = true;
                }
                else
                {
                    proceedAllowed = false;
                    Console.WriteLine("you a to lat for you plaen");
                }

                if (proceedAllowed)
                {
                    lock (Program.bagedCheckedIn)
                    {
                        if (Program.BagedList.Count >= 50)
                        {
                            Monitor.Wait(Program.bagedCheckedIn);
                        }
                        //OffLoad()
                        Program.bagedCheckedIn.Add(suitcase);
                        Monitor.PulseAll(Program.bagedCheckedIn);
                    }
                }
                Thread.Sleep(1000);
            }

        }
    }
}
