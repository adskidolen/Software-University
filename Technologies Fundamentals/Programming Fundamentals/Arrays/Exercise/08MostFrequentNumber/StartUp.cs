﻿namespace _08MostFrequentNumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxCount = 0;
            int repeatingNumber = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                int currentCount = 0;

                for (int j = i; j < sequence.Length; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    repeatingNumber = sequence[i];
                    maxCount = currentCount;
                }
            }

            Console.WriteLine(repeatingNumber);
        }
    }
}