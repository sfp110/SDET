using System;

namespace MemoryModel
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class Passsamethod
    {
        public static void Main()
        {
            Person tak = new Person { FirstName = "Tak", LastName = "Li", Age = 25 };
            double jacob = 4.2;
            string keagan = DemoMethod(tak, jacob);
            int chris;
            var success = Int32.TryParse("632", out chris);
            int sabir = 42;
            PassByReference(sabir, out int atchu);
            Console.WriteLine(atchu);

            int a = 5; int b = 2;
            Swap(ref a, ref b);

            Console.WriteLine(a + "," + b);
        }
        public static string DemoMethod(Person denzel, double umar)
        {
            denzel.LastName = "Sawyer";
            denzel.Age = 26;
            umar *= 2;
            return denzel.FirstName;
        }

        public static void PassByReference(in int denzel, out int umar)
        {
            umar = 2 * denzel;
        }

        public static void Swap(ref int x, ref int y)
        {
            int c = 0;
            c = x;
            x = y;
            y = c;
        }
    }
}
