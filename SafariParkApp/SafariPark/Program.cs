using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Weapon> weapons = new List<Weapon>()
            //    {
            //    new LaserGun("Banana"),
            //    new WasterPistol("Umbrella"),
            //    };

            //LaserGun firstGun = new LaserGun("Nerf");
            //weapons.Add(firstGun);

            //foreach (var gun in weapons)
            //{
            //    Console.WriteLine(gun.Shoot());
            //}

            Camera pentax = new Camera("Pentax");
            WasterPistol pistol = new WasterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            
            //Console.WriteLine(nish.CameraName()); // SafariPark.WasterPistol
            

            //var cannon = new Camera("Cannon");
            //var yolanda = new Person("Yolanda", "Young");
            //SpartaWrite(yolanda);
            //var martinHunter = new Hunter("Martin", "Beard", cannon) {Age = 43};
            //SpartaWrite(martinHunter);

            #region ListOfObjects

            //var gameObjects = new List<object>()
            //{
            //    new Person("Cathy", "French"),
            //    new Airplane(400, 200, "Booing") {NumPassengers = 55},
            //    new Vehicle(12, 20) {NumPassengers = 6},
            //    new Hunter("Henry", "Hodgkins", pentax)
            //};

            //foreach (var gameObject in gameObjects)
            //{
            //    Console.WriteLine(gameObject);
            //}

            #endregion

            #region ImplementingIMovableInterface

            //Console.WriteLine("\n");
            //var gameObjects2 = new List<IMovable>()
            //{
            //    new Person("Cathy", "French"),
            //    new Airplane(400, 200, "Booing") {NumPassengers = 55},
            //    new Vehicle(12, 20) {NumPassengers = 6},
            //    new Hunter("Henry", "Hodgkins", pentax)
            //};

            //foreach (var gameObject2 in gameObjects2)
            //{
            //    Console.WriteLine(gameObject2.Move());
            //    Console.WriteLine(gameObject2.Move(20));
            //}
            //Console.WriteLine("\n");

            #endregion

            #region Old Exercises

            // var h = new Hunter("Marion", "Jones", "Canon") { Age = 25 };
            // //Console.WriteLine($"{nHunter.FullName}, of {nHunter.Age}, took his photo with a {nHunter.CameraName()} camera. \n");
            // Console.WriteLine($"{h.FullName}, of {h.Age}, took his photo with a {h.Camera} camera. \n");
            //
            // var h2 = new Hunter("Sergio", "Pessegueiro", "Leica") { Age = 22 };
            //
            // Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            // Console.WriteLine($"h HashCode:  {h.GetHashCode()}");
            // Console.WriteLine($"h Type:      {h.GetType()}");
            // Console.WriteLine($"h ToString:  {h.ToString()}");
            //
            // Console.WriteLine($" \n h: {h} \n");
            //
            // //----------------------------------------------------------
            //
            // Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150};
            //
            // a.Ascend(500);
            // Console.WriteLine(a.Move(3));
            // Console.WriteLine(a);
            // a.Descend(200);
            // Console.WriteLine(a.Move());
            // a.Move();
            // Console.WriteLine(a + "\n");
            //
            // //----------------------------------------------------------
            //
            //
            // Person martin = new Person("Martin", "Beard", 21);
            // Console.WriteLine(martin.GetFullName());
            //
            // var cathy = new Person("Cathy", "French", 35);
            // Console.WriteLine(cathy.GetFullName() + " of " + cathy.Age);
            //
            // var sergio = new Person("Sergio", "Pessegueiro") { Age = 22 };
            // Console.WriteLine(sergio.GetFullName() + " of " + sergio.Age);
            //
            // var list = new ShoppingList()
            // {
            //     Bread = 2,
            //     Potato = 6,
            //     Milk = 2
            // };
            //
            // Point3D p1 = new Point3D(3, 6, 2);
            // //var p2 = new Point3D();
            // //Point3D p3;
            // //Point3D p4 = new Point3D(1, 7W);
            //
            //
            // var john = new Person("John", "Doe") { Age = 20 };
            //
            // var pt = new Point3D(5, 1000, 2);
            //
            // DemoMethod(pt, john);

            #endregion
        }

        private static void SpartaWrite(object obj)
        {
            if (obj is not IMovable) return;
            
            if (obj is Hunter hunterObject)
            {
                Console.WriteLine(hunterObject.Shoot());
                Console.WriteLine(hunterObject.Move());
            }
            Console.WriteLine(obj.ToString());

        }


        private static void DemoMethod(Point3D pt, Person p )
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
