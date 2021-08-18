using System;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("*****Welcome to Airplane*****\n Press any key to continue.");
            Console.ReadLine();
            Console.WriteLine("%%%%%Airplane is program where you can%%%%%\n%%%%%view a variety of information for%%%%%\n%%%%%popular airplanes. Press any key to continue%%%%%");
            Console.ReadLine();
            SevenFourSeven fourhundred = new SevenFourSeven();
            fourhundred.airline = "Lufthansa (LH)";
            fourhundred.manufacturer = "Boeing";
            fourhundred.flightNumber = 7540;
            Console.WriteLine(fourhundred.airline);
            //Console.WriteLine(fourhundred.flightNumber);
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            AThree twenty = new AThree();
            twenty.airline = "Air France (AF)";
            twenty.manufacturer = "Airbus";
            twenty.flightNumber = 1145;
            Console.WriteLine(twenty.airline);
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            SevenSevenSeven threehundreder = new SevenSevenSeven();
            threehundreder.airline = "Austrian Airlines (AX)";
            threehundreder.manufacturer = "Boeing";
            threehundreder.flightNumber = 1890;
            Console.WriteLine(threehundreder.airline);
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            SevenEightSeven eight = new SevenEightSeven();
            eight.airline = "American (AM)";
            eight.manufacturer = "Boeing";
            eight.flightNumber = 1946;
            Console.WriteLine(eight.airline);
            //Console.WriteLine(eight.airline);
            //Console.WriteLine("Hello World!");
            Console.ReadLine();

            Console.WriteLine(GetFlightNumber(0));
            Console.ReadLine();
            Console.WriteLine(GetDepartureTime(0));
            Console.ReadLine();
            Console.WriteLine(GetFlightNumber(1));
            Console.ReadLine();
            Console.WriteLine(GetDepartureTime(1));
            Console.ReadLine();
            Console.WriteLine(GetFlightNumber(2));
            Console.ReadLine();
            Console.WriteLine(GetDepartureTime(2));
            Console.ReadLine();
            Console.WriteLine(GetFlightNumber(3));
            Console.ReadLine();
            Console.WriteLine(GetDepartureTime(3));
            Console.ReadLine();
        }

        static string GetFlightNumber(int theAirline)
        {
            string numberFlight;

            switch (theAirline)
            {
                case 0: //Lufthansa
                    numberFlight = "LH7540";
                    
                    break;
                case 1: //Air France
                    numberFlight = "AF1145";

                    break;
                case 2: //Austrian Airlines
                    numberFlight = "AX1890";

                    break;
                case 3: //American
                    numberFlight = "AM1946";

                    break;
                default:
                    numberFlight = "Invalid airline";
                    break;
            }

            return numberFlight;
        }

        static string GetDepartureTime (int theTime)
        {
            string theDigits;

            switch (theTime)
            {
                case 0: //Lufthansa 7540
                    theDigits = "09:30";

                    break;
                case 1: //Air France 1145
                    theDigits = "13:30";

                    break;
                case 2: //Austrian Airlines 1890
                    theDigits = "17:30";

                    break;
                case 3: //American 1946
                    theDigits = "22:00";

                    break;
                default:
                    theDigits = "Invalid time";
                    break;

            }

            return theDigits;
        }
    }
}