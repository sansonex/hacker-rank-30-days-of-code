using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public abstract class Challenge
    {
        public string[] Input { get; set; }

        public string[] Readme { get; set; }

        public Challenge()
        {
            this.Input = FileHandler.ReadFile(this.GetType().Name, "sample_input");
            this.Readme = FileHandler.ReadFile(this.GetType().Name, "readme");

            foreach (var line in Readme)
            {
                Console.WriteLine(line);
            }
        }
    }
}
