using System;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter h = new Hunter("Marion", "Jones", "Canon") { Age = 25 };
            //Console.WriteLine($"{nHunter.FullName}, of {nHunter.Age}, took his photo with a {nHunter.CameraName()} camera. \n");
            Console.WriteLine($"{h.FullName}, of {h.Age}, took his photo with a {h.Camera} camera. \n");


            var h2 = new Hunter("Sergio", "Pessegueiro", "Leica") { Age = 22 };

            Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            Console.WriteLine($"h HashCode:  {h.GetHashCode()}");
            Console.WriteLine($"h Type:      {h.GetType()}");
            Console.WriteLine($"h ToString:  {h.ToString()}");

            Console.WriteLine($" \n h: {h} \n");

            //----------------------------------------------------------

            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150};

            a.Ascend(500);
            Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a + "\n");

            //----------------------------------------------------------


            Person martin = new Person("Martin", "Beard", 21);
            Console.WriteLine(martin.GetFullName());

            Person cathy = new Person("Cathy", "French", 35);
            Console.WriteLine(cathy.GetFullName() + " of " + cathy.Age);

            Person Sergio = new Person("Sergio", "Pessegueiro") { Age = 22 };
            Console.WriteLine(Sergio.GetFullName() + " of " + Sergio.Age);

            var list = new ShoppingList()
            {
                Bread = 2,
                Potato = 6,
                Milk = 2
            };

            Point3D p1 = new Point3D(3, 6, 2);
            var p2 = new Point3D();
            //Point3D p3;
            //Point3D p4 = new Point3D(1, 7);


            Person john = new Person("John", "Doe") { Age = 20 };

            Point3D pt = new Point3D(5, 1000, 2);

            DemoMethod(pt, john);
        }

        
        static void DemoMethod(Point3D pt, Person p )
            {
            //copy of the value of the struct (it's inside of the stack)
            //reference of the class Person
            pt.y += 1000; //copy of the value
            p.Age = 92;  //actual value
            }
    }
    public struct Point3D
    {
        public int x;
        public int y, z;

        public Point3D(int x, int y, int z = 5)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

}
