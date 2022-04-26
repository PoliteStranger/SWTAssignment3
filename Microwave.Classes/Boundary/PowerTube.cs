using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private IOutput myOutput;
        private int _maxPower;
        private bool IsOn = false;

        public PowerTube(IOutput output, int maxpower)
        {
            myOutput = output;
            if (maxpower < 50)
            {
                throw new ArgumentOutOfRangeException("Maxpower", _maxPower, "Must be at least 50");
            }
            else
            {
                _maxPower = maxpower;
            }
            
        }

        public void TurnOn(int power)
        {
            if (power < 1 || _maxPower < power)
            {
                throw new ArgumentOutOfRangeException("power", power, "Must be below the maximum power, and above 1 (incl.)");
            }

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {power}");
            IsOn = true;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                myOutput.OutputLine($"PowerTube turned off");
            }

            IsOn = false;
        }
    }
}