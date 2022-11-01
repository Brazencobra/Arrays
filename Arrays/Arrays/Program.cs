using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int[] numbers = { 13, 18, 3, 34 };
            //int minimumnum = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (minimumnum > numbers[i])
            //    {
            //        minimumnum = numbers[i];
            //    }

            //}
            //Console.WriteLine("En kiçik element:" + minimumnum);
            #endregion

            #region Task2
            int[] numbers = { 1, 13, 5, 77, };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 10)
                {
                    sum++;

                }
            }
            Console.WriteLine("Verilmiş numunede " + sum + " reqem var");

            #endregion
        }
    }
}
