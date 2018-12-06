using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitTest.Services;

namespace GitTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            INameService nameService = new NameService();
            Console.Write(nameService.GetName());

            Console.ReadKey();
        }
    }
}
