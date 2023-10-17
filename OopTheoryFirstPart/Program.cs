using OopTheoryLibrary;

namespace OopTheoryFirstPart
{
    internal class Program
    {
        static void Main(params string[] args)
        {
            /*
            int i = 10;
            Console.WriteLine($"{nameof(Main)} - Before Increment: {i}");
            ParametersPassing.Increment(i);
            Console.WriteLine($"{nameof(Main)} - After Increment: {i}");
            */

            Person p = new Person("John Doe", new DateTime(1995, 10, 17));

            Console.WriteLine($"{nameof(Main)} - Before name modify: {p.Name}");
            ParametersPassing.ChangePersonName2(p);
            Console.WriteLine($"{nameof(Main)} - After name modify: {p.Name}");
        }
    }
}