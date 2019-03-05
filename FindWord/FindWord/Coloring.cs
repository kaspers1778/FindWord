using System;
namespace FindWord
{

    static class Coloring
    {
        static private Random rand = new Random();
        static private Array values = Enum.GetValues(typeof(ConsoleColor));

        static public void ColoredWriteLine(ConsoleColor color, string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = prevColor;
        }

        static public void ColoredWrite(ConsoleColor color, string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ForegroundColor = prevColor;
        }

        static public void RandomColoredWriteLine(string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)values.GetValue(rand.Next(values.Length));
            Console.WriteLine(value);
            Console.ForegroundColor = prevColor;
        }

        static public void RandomColoredWrite(string value)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)values.GetValue(rand.Next(values.Length));
            Console.Write(value);
            Console.ForegroundColor = prevColor;
        }
    }
}
