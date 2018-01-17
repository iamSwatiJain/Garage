using System;

namespace Garage
{
    public static class Helpers
    {
        public static Int32 GetMenuChoice(Int32 max)
        {
            Int32 menu;

            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out menu) && menu < 0 && menu > max)
                {
                    Console.WriteLine($"Your input is not an integer. Please enter digits only between 0-{max}. Try again!");
                }
                else
                {
                    break;
                }
            } while (true);

            return menu;
        }

        public static Int32 GetInt()
        {
            Int32 value;

            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"Your input is not an integer.Try again!");
                }
                else
                {
                    break;
                }
            } while (true);

            return value;
        }

        public static Double GetDouble()
        {
            Double value;

            do
            {
                if (!Double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"Your input is not double.Try again!");
                }
                else
                {
                    break;
                }
            } while (true);

            return value;
        }
    }
}
