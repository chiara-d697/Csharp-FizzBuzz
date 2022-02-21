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

            if (n % 7 == 0)
            {
                output += "Bang"; 
            }

            if (n % 11 == 0)
            {
                output = "Bong"; 
            }

            if (output == "")
            {
                output += n.ToString();
            }

            return output;
        }
    }
}