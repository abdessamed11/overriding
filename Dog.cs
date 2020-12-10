using System;
using System.Collections.Generic;
using System.Text;

namespace overriding
{
    class Dog : Animals
    {
        public override void say()
        {
            Console.WriteLine("i'm dog i have a old" );
        }

    }
}
