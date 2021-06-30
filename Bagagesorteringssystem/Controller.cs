using System;
using System.Collections.Generic;
using System.Text;

namespace Bagagesorteringssystem
{
    class Controller
    {
        //Dynamically create thread

        public int MakeChackInList()
        {
            int ChackInNumber = 0;
            //Make a list of ChackIn ther a need
            for (int i = 0; i < Program.BagedList.Count; i++)
            {
                ChackInNumber++;
                switch (ChackInNumber)
                {
                    case 20:
                        //chackIn.Start(1);
                        //chackIn1
                        break;
                    case 30:
                        //chackIn.Start(2);
                        //chackIn2
                        break;
                    case 40:
                        //chackIn.Start(3);
                        //chackIn3
                        break;
                    case 50:
                        //chackIn.Start(4);
                        //chackIn4
                        break;
                    case 60:
                        //chackIn.Start(5);
                        //chackIn5
                        break;
                    default:
                        Console.Write(".");
                        break;
                }
            }
        }        
        public int MakeGateList()
        {
            int GateNumber = 0;
            //Make a list of Gate ther a need
            for (int i = 0; i < Program.ListOfFlight.Count; i++)
            {
                GateNumber++;
            }
        }
        //ChackInList
        //GateList

        //chackqueueBC()
        //OpenChackInThread()
        //CloseChackInThread()
        //OpenGateThread()
        //CloseGateThread()
    }
}
