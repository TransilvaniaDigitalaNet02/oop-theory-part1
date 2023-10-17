using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTheoryLibrary
{
    public static class ParametersPassing
    {
        public static void Increment(int i, out int incremented)
        {
            incremented = 0;
            Console.WriteLine($"{nameof(ParametersPassing)} - Value before increment: {i}");
            incremented = i + 1;
            Console.WriteLine($"{nameof(ParametersPassing)} - Value after increment: {incremented}");
        }

        public static void ChangePersonName(Person person)
        {
            Console.WriteLine($"{nameof(ParametersPassing)} - Name before change: {person.Name}");
            person.ChangePersonalData("Changed name");
            Console.WriteLine($"{nameof(ParametersPassing)} - Name after change: {person.Name}");
        }

        public static void ChangePersonName2(ref Person person)
        {
            Console.WriteLine($"{nameof(ParametersPassing)} - Name before change: {person.Name}");
            person = new Person("Changed name", person.DateOfBirth);
            Console.WriteLine($"{nameof(ParametersPassing)} - Name after change: {person.Name}");
        }
    }
}
