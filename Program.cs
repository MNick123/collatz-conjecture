using System;
using System.Threading;
namespace collatz_conjecture
{
    class Program
    {
        public static void Main(string[] args)
        {
           first:
            Console.WriteLine("Collatz conjeture, type any positive number");
            string numberinputraw = Console.ReadLine();



            try
            {
                Convert.ToInt32(numberinputraw);
            }
            catch
            {
                Console.WriteLine("You enterd a invid number");
                goto first;
            }


            #region
            long Number = Convert.ToInt64(numberinputraw);

            if(Number <= 0)
            {
                Console.WriteLine("Enter A valid number");
                goto first;

            }

            Start:
            if(Number%2 == 0)
            {
                Console.WriteLine("number is even");
                Number = Number / 2;
                Console.WriteLine(Number);
                Thread.Sleep(500);
            }
            else if(Number == 1)
            {
                Console.WriteLine("Your Number is one which starts a loop");
                Thread.Sleep(-1);
            }
            else
            {
                Console.WriteLine("Number is odd");
                Number = Number * 3 + 1;
                Console.WriteLine(Number);
                Thread.Sleep(500);
            }
            goto Start;
            #endregion

        }


    }
}
