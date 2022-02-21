using System;

namespace FizzBuzz 
{
    class Progam
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var fizBuzzer = new FizzBuzzer();
                Console.WriteLine(fizBuzzer.FizzBuzz(i));
            }
        }
    }
}