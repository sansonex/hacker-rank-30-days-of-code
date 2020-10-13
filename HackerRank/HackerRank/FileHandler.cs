using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace HackerRank
{
    public static class FileHandler
    {
        public static string[] ReadFile(string day, string fileName)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"challenges\{day}\{fileName}.txt");

            return File.ReadAllLines(path);
        }
    }
}
