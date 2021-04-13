using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4._3PrimeNumbers
{
    public class PrimeNumbers
    {
      
        public int GetPrime(int userNumber)
        {
            int number = 0;
            int primeNumber = 0;

            while (primeNumber != userNumber)
            {

                number++;
                int dividedNum = 0;
                       
                for (int i = 1; i <= number; i++)
                {
                    if(number % i == 0)
                    {

                        dividedNum++;
                    }
                }
                if(dividedNum == 2)
                {

                    primeNumber++;
                }


            }

            return number;
           


            

        }
    }
}
