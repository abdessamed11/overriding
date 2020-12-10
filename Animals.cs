using System;
using System.Collections.Generic;
using System.Text;

namespace overriding
{
    class Animals
    {
        int name;

        public virtual void say()
        {
            Console.WriteLine("i'm animals");
        }
    }
}
