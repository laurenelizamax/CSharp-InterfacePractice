using System;

namespace interfacePractices
{
    public class PaintedDog : IWalking
    {
        public void Run()
        {
            Console.WriteLine("He's so fast");
        }
        public void Walk()
        {
            Console.WriteLine("He's sneaky");

        }

    }
}