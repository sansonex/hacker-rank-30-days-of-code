using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Challenges.Day6
{
    public class Day6 : Challenge
    {
        public Day6()
        {
            Start();
        }

        public void Start()
        {
            CalcMultiple(10, int.Parse(Input[0]));
        }

        public void CalcMultiple(int howManyTimes, int number)
        {
            for (int i = 1; i <= howManyTimes; i++)
            {
                Console.WriteLine($"{number} x {i} = " + i * number);
            }
        }
    }
}
