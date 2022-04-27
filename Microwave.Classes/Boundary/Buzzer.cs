using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class Buzzer : IBuzzer
    {
        //primarily for testing
        public int LastBuzzAmount { get; set; } = 0;
        public void BurstBuzz(int times)
        {
            //reset last buzz amount
            LastBuzzAmount = 0;
            //throw argumentoutofrange if buzzer receives illegal inputs under 1 or over 20
            if (times < 1 || times > 20)
            {
                throw new ArgumentOutOfRangeException("Times", times, "is out of the permitted range 1-20 (incl.)");
            }

            //loop through times of buzzes, that are given in  the parameter, only wait for new buzz if the current buzz isnt the last
            for (int i = 0; i < times; i++)
            {
                LastBuzzAmount++;
                Console.WriteLine("Beep!");
                if (i < times)
                    Thread.Sleep(200);
            }
        }
    }
}
