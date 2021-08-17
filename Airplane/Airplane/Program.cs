using System;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("*****Welcome to Airplane*****\n Press any key to continue.");
            Console.ReadLine();
            Console.WriteLine("%%%%%Airplane is program where you can%%%%%\n%%%%%view a variety of information for%%%%%\n%%%%%popular airplanes. Press any key to continue%%%%%");
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
            //Console.ReadLine();

            SevenSevenSeven threehundreder = new SevenSevenSeven();
            threehundreder.airline = "Austrian Airlines";
            threehundreder.manufacturer = "Boeing";
            threehundreder.flightNumber = 1890;
            Console.WriteLine(threehundreder.flightNumber);
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            SevenEightSeven eight = new SevenEightSeven();
            eight.airline = "American";
            eight.manufacturer = "Boeing";
            eight.flightNumber = 1946;
            Console.WriteLine(eight.flightNumber);
            //Console.WriteLine("Hello World!");
            */

            Console.WriteLine(GetFlightNumber(0));
            Console.ReadLine();
        }

        static string GetFlightNumber(int theAirline)
        {
            string numberFlight;

            switch (theAirline)
            {
                case 0: //Lufthansa
                    numberFlight = "7540";
                    
                    break;
                case 1: //Air France
                    numberFlight = "1145";

                    break;
                case 2: //Austrian Airlines
                    numberFlight = "1890";

                    break;
                case 3: //American
                    numberFlight = "1946";

                    break;
                default:
                    numberFlight = "Invalid airline";
                    break;
            }

            return numberFlight;
        }
    }
}
//implement case rather than if statement
//user enter Lufthansa-> return 7540
//Air France->1145
//n->n