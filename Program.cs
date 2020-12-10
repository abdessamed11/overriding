using System;

namespace overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals an = new Animals();
            an.say();
            Dog dog1 = new Dog();
            dog1.say();

        }
    }
}
