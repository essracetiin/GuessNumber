using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int number = random.Next(101);

                int? claim = 0;
                int data = 0;
                while (number != data)
                {
                    claim++;
                    Console.WriteLine("Please enter a number between 1 and 100");
                    string enteredNumber = Console.ReadLine();
                    bool isValid = Int32.TryParse(enteredNumber, out data);
                    if (isValid)
                    {
                        if (data == number)
                        {
                            Console.WriteLine("Congratulations, you got it with {0} guesses", claim);
                        }
                        else if ((number - data) <= 3 && (data - number) <= 3)
                        {
                            Console.WriteLine("Too Hot!");
                        }
                        else if ((data - number) <= 20 && (number - data) <= 20)
                        {
                            Console.WriteLine("Hot");
                        }
                        else
                        {
                            Console.WriteLine("Cold");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter correct value!");
                    }



                }
            }
            


        }
    }
}

