using System;

namespace Lab4._3PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's locate some primes!\nThis application will find you any prime, in order, from first prime number on.");
            Console.WriteLine("");
            PrimeNumbers primeSelection = new PrimeNumbers();
            bool again = true;

            while (again)
            {
                Console.WriteLine("Which Prime number are you looking for ?");
                int primeNumber = Int32.Parse(Console.ReadLine());
                int result = primeSelection.GetPrime(primeNumber);
                
                Console.WriteLine($"The number {primeNumber} prime is {result}");

                again = ContinuePlaying();
            }

        }


        public static bool ContinuePlaying()
        {
            bool invalidInput = true;

            do
            {
                Console.WriteLine(" Do you want to find another prime number ? (y/n) ");
                string userInput = Console.ReadLine().ToLower();


                if (userInput == "y" || userInput == "yes")
                {

                    return true;
                }
                else if (userInput == "n" || userInput == "no")
                {

                    Console.WriteLine("Thank you for playing!");
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid selection");
                }

            } while (invalidInput);

            return true;
        }


    }
}
