using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTheoryLibrary
{
    public static class ParametersPassing
    {
        public static void Increment(int i)
        {
            Console.WriteLine($"Value before increment: {i}");
            i = i + 1;
            Console.WriteLine($"Value after increment: {i}");
        }
    }
}
