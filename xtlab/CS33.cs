using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xtlab
{
    internal class CS33
    {

        class Horn
        {
            public void Beep() => Console.WriteLine("BEEPP");
        }
        class Car
        {
            public void Beep()
            {
                Horn horn = new Horn();
                horn.Beep();
            }
        }
    }
}
