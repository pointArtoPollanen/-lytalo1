using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Älytalo1
{
    public class Thermostat
    {
        int Temperature;

        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
        }

        public int GetTemperature()
        {
            return Temperature;
        }
    }
}
