using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Älytalo1
{
    public class Lights
    {
        bool Switched { get; set; }
        string Dimmer { get; set; }

        public void SetDimmer(string percent)
        {
            Dimmer = percent;
            if (percent == "0")
            {
                Switched = false;
            }
            else
            {
                Switched = true;
            }
        }

        public string GetText()
        {
            if (!Switched)
            {
                return "OFF";
            }
            else
            {
                return "ON: " + Dimmer + " %";
            }
        }
    }
}
