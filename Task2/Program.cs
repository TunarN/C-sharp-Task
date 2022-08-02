using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "Fevral";
            switch (month)
            {
                case "Yanvar": case "Mart": case "May": case "Iyul": case "Avqust": case "Oktyabr": case "Dekabr":
                    Console.WriteLine("31");
                    break;
                case "Aprel": case "Iyun": case "Sentyabr": case "Noyabr":
                    Console.WriteLine("30");
                    break;
                case "Fevral":
                    Console.WriteLine("28");
                    break;

            }
        }
    }
}
