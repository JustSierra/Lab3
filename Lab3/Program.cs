using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            string name = Console.ReadLine();
            bool Asking = true;
            while (Asking == true)
            {
                Console.WriteLine("enter a number between 1 and 100");
                string input = Console.ReadLine();
                int num = int.Parse(input);

                bool even = IsEven(num);
                if (num >= 1 && num <= 100)
                {

                }
            }    }
}
