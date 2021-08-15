using System;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Airplane*****\n Press any key to continue.");
            Console.ReadLine();
            SevenFourSeven fourhundred = new SevenFourSeven();
            fourhundred.airline = "Lufthansa";
            fourhundred.manufacturer = "Boeing";
            fourhundred.flightNumber = 7540;
            Console.WriteLine(fourhundred.flightNumber);
            //Console.WriteLine(fourhundred.flightNumber);
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            AThree twenty = new AThree();
            twenty.airline = "Air France";
            twenty.manufacturer = "Airbus";
            twenty.flightNumber = 1145;
            Console.WriteLine(twenty.flightNumber);
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
