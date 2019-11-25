using System;
using System.Collections.Generic;

namespace interfacePractices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISwimming> swimmers = new List<ISwimming>();
            List<IWalking> walkers = new List<IWalking>();

            // Instance of a tesla class, we treat it as an ielectricvehicle
            var myDog = new PaintedDog();
            var myTurtle = new SeaTurtle();


            swimmers.Add(myTurtle);

            walkers.Add(myDog);

            foreach (var animal in swimmers)
            {
                animal.Swim();
                {
                    Console.WriteLine("He's a fast swimmer");
                }
            }

            foreach (var animal in walkers)
            {
                animal.Run();
                {
                    Console.WriteLine("He's a slow runner");

                }
            }
        }
    }
}
