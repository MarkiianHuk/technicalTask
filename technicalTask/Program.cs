using System;
using System.Collections.Generic;


namespace technicalTask
{
    class Program
    {
        public static int[] IntToIntArray(int num)
        {
            if (num == 0)
                return new int[1] { 0 };

            List<int> digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            int[] array = digits.ToArray();
            System.Array.Reverse(array);

            return array;
        }
        public static void IsLuckyTicket(int[] digitarray)
        {
            int sumFirst = 0;
            int sumSecond = 0;
            for (int i = 0; i < digitarray.Length / 2; i++)
            {
                sumFirst += digitarray[i];
            }
            for (int i = digitarray.Length / 2; i < digitarray.Length; i++)
            {
                sumSecond += digitarray[i];
            }
            if (sumFirst == sumSecond)
            {
                Console.WriteLine($"lucky ticket");
            }
            else
            {
                Console.WriteLine("unlucky ticket");
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Write your ticket:");
                int ticket = Convert.ToInt32(Console.ReadLine());
                int[] digitarray = IntToIntArray(ticket);
                if (digitarray.Length > 3 && digitarray.Length < 8)
                {
                    if (digitarray.Length % 2 == 0)
                    {
                        IsLuckyTicket(digitarray);
                    }
                    else
                    {
                        int n = digitarray.Length;
                        int x = 0;
                        int pos = 1;
                        int[] newarr = new int[n + 1];

                        for (int i = 0; i < n + 1; i++)
                        {
                            if (i < pos - 1)
                                newarr[i] = digitarray[i];
                            else if (i == pos - 1)
                                newarr[i] = x;
                            else
                                newarr[i] = digitarray[i - 1];
                        }
                        IsLuckyTicket(newarr);
                    }
                }
                else
                {
                    Console.WriteLine("Please write correct ticket");
                }
            }
            while (true);
        }
    }
}
