using System;
using System.Collections.Generic;
using System.Text;

namespace primerExamen
{
    class main
    {
        public static void Main(string [] args)
        {
            DateTime x = DateTime.Now;
            TimeSpan f = new TimeSpan(30,0,0,0);
            DateTime m = x + f;
        }
    }
}
