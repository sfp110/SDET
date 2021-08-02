using System;

namespace MoreMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pizza1 = OrderPizza(pineapple: true, anchovies: true);

            Console.WriteLine(pizza1);

            var result = DoThis(10, "Sad");
            var result2 = DoThis(10);

            var myTuple = ("Joe", "Bloggs", 25);
        }

        public static void MyTuppleTest(string myTuple)
        {

        }

        public static (int stones, int pounds) ConvertPoundsToStones(int Pounds)
        {
            const int poundsInAStone = 14;
            var st = Pounds / poundsInAStone;
            var lbs = Pounds % poundsInAStone;
            return (st, lbs);
        }

        public static int DoThis(int x, string y = "Happy")
        {
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }

        public static string OrderPizza(bool anchovies, bool pineapple, bool mushroom = false)
        {
            var pizza = "Pizza with tomato sauce, cheese, ";
            if (anchovies) pizza += "achovies, ";
            if (pineapple) pizza += "pineapple, ";
            if (mushroom) pizza += "mushroom, ";

            return pizza.Substring(0, pizza.Length - 2) + ".";

        }
    }
}
