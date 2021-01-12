﻿using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = 0.10 * number;
            }
            else
            {
                bonus = 0.20 * number;
            }

            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }

            double totalScore = bonus + number;

            Console.WriteLine(bonus);
            Console.WriteLine(totalScore);
         
        }
    }
}
