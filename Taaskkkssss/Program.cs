
using System;

namespace Taaskkkssss
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "aprel";
            switch (month)
            {
                case "yanvar": case "mart": case"may": case "iyul": case"oktyabr": case "dekabr":
                    Console.WriteLine("31");
                    break;
                case "aprel": case "iyun": case "sentyabr": case "noyabr":
                    Console.WriteLine("30");
                    break;
                case "fevral":
                    Console.WriteLine("28");
                    break; 
            }
        }
    }
}
