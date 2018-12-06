using System;
using GitTest.Services;

namespace GitTest
{
    public class Program
    {
        // This is very complex and a lot of people work on that
        public static void Main(string[] args)
        {
            INameService nameService = new NameService();
            Console.Write(nameService.GetName());

            Console.ReadKey();
        }
    }
}