using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscordRestApiLib.Data
{
    public class BadClass
    {
        public int A { get; set; }

        public int B { get; set; }
    }

    public class Test
    {
        public static void Testing(BadClass a)
        {
            if (a != null && a.A != null)
            {
                a.A = +a.B; 
            }
        }
    }
}
