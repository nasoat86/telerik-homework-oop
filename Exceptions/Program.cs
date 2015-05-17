using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void IntExample(int[] array, int start, int end)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < start || array[i] > end)
                {
                    string msg = "The input value (" + array[i] + ") in not in range: ";
                    throw new InvalidRangeException<int>(msg, start, end);
                }
            }
        }

        static void DateExample(DateTime[] array, DateTime start, DateTime end)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < start || array[i] > end)
                {
                    string msg = "The input value (" + array[i].ToShortDateString() + ") is not in range: ";
                    throw new InvalidRangeException<DateTime>(msg, start, end);
                }
            }
        }

        static void Main(string[] args)
        {
            int startI = 1;
            int endI = 100;

            int[] intArray = { 12, 26, 34, 87, 97, 134, 66, -1 };

            DateTime startD = new DateTime(1990, 1, 1);
            DateTime endD = new DateTime(2011, 12, 31);
            DateTime[] dateArray = {
                                    new DateTime(2007, 1, 23),
                                    new DateTime(2017, 5, 13),
                                    new DateTime(2000, 3, 12),
                                    new DateTime(1973, 7, 25),
                                    new DateTime(2004, 11, 30)
                                   };
            try
            {
                IntExample(intArray, startI, endI);
            }
            catch (InvalidRangeException<int> msg)
            {
                Console.WriteLine("{0}[{1}...{2}]", msg.Message, msg.Start, msg.End);
            }

            try
            {
                DateExample(dateArray, startD, endD);
            }
            catch (InvalidRangeException<DateTime> msg)
            {
                Console.WriteLine("{0}[{1}...{2}]", msg.Message, msg.Start.ToShortDateString(), msg.End.ToShortDateString());
            }
        }
    }
}
