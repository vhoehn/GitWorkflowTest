using System;
using GitTest.Services;

namespace GitTest
{
    public class Program
    {
        //Dingdong
        public static void Main(string[] args)
        {
            INameService nameService = new NameService();
            Console.Write(nameService.GetName());

            Console.ReadKey();
        }
    }
}