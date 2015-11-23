using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Älytalo1
{
    public class Sauna
    {
        bool Switched { get; set; }

        public void SetOn()
        {
            Switched = true;
        }

        public void SetOff()
        {
            Switched = false;
        }

        public string GetText()
        {
            if (Switched)
            {
                return "SAUNA PÄÄLLÄ";
            }
            else
            {
                return "";
            }
        }
    }
}
