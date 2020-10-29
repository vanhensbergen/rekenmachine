using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekenmachine.models
{
    class Rekenaar
    {
        private int Getal1;
        private int Getal2;
        public int TelOp()
        {
            return Getal1 + Getal2;
        }

        public bool IsGetal1(string txt)
        {
            return int.TryParse(txt, out Getal1);
        }
        public bool IsGetal2(string txt)
        {
            return int.TryParse(txt, out Getal1);
        }

        public int TrekAf()
        {
            return Getal1 - Getal2;
        }
    }
}
