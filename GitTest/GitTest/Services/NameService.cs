using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest.Services
{
    public class NameService : INameService
    {
        public string GetName()
        {
            return "Some name";
        }
    }
}
