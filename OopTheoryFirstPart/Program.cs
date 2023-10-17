using OopTheoryLibrary;

namespace OopTheoryFirstPart
{
    internal class Program
    {
        static void Main(params string[] args)
        {
            Person person = new Person(dateOfBirth: new DateTime(1993, 10, 12), name: "John Doe");
            person.PresentYourself();

            person.ChangePersonalData("John Doee");
            person.PresentYourself();

            IntArray array = new IntArray(new[] { 1, 2, 3 });
            Console.WriteLine("Sum=" + array.Sum());
            Console.WriteLine("Element at index 0=" + array[0]);

            /* Method overloading */
            ConsoleHelper.PrintMessage("This is a message");
            ConsoleHelper.PrintMessage("This is a message", "Label");
            ConsoleHelper.PrintMessage("This is a message", 2);

            int[] array2 = new[] { 1, 2, 3, 4 };
            RecursivityHelper.Iterate(array2);

            /* Methods with optional params */
            decimal price1 = PriceCalculator.CalculatePrice(unitPrice: 10);
            decimal price2 = PriceCalculator.CalculatePrice(unitPrice: 15, quantity: 3);
            decimal price3 = PriceCalculator.CalculatePrice(unitPrice: 20, quantity: 5, vatPercent: 9);
            decimal price4 = PriceCalculator.CalculatePrice(20, vatPercent: 9);
        }
    }
}