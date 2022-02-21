using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int n)
        {
            string output = "";

            if (n % 3 == 0)
            {
                output += "Fizz"; 
            }
            
             if (n % 5 == 0)
            {
                output += "Buzz"; 
            }

            else 
            {
                output += n.ToString();
            }

            return output;
        }
    }
}