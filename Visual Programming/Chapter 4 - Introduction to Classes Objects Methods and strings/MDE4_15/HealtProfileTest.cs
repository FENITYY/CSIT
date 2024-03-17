using System;
using System.IO.Pipes;

namespace MDE4_15
{
    class HealtProfileTest
    {
        static void Main() {
            HealtProfile starter = new HealtProfile("Efe Can", "Kara", "male", 27, 9, 2003,220, 67 );

            starter.GetID();
            starter.GetReport();
        }
    }
}