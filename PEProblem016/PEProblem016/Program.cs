using System;
/*
 * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
 * 
 * What is the sum of the digits of the number 2^1000?
 */
namespace PEProblem016
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;
            
            int[] array = new int[400];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }

            array[0] = 2;
            int tmp = 0;
            int tmp2 = 0;

            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    tmp = array[j] * 2 + tmp2;
                    tmp2 = tmp / 10;
                    array[j] = tmp - tmp2 * 10;
                }
            }

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
