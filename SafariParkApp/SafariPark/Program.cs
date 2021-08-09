using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {

            //System.Collections.Generic is a namespace
            //What can we do with regards to handling types ? classes/strucs

            var helen = new Person("Helen", "Troy") { Age = 42 };
            var will = new Person("William", "Shakespeare") { Age = 467 };

            #region DICTIONARY
            //DICTIONARY

            var personDict = new Dictionary<string, Person>
            {
                { "helen", helen },
                { "sherlock", new Person("Sherlock", "Holmes"){ Age = 40 } }
            };

            var p = personDict["sherlock"];
            personDict.Add("will", will);

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();

            var countDict = new Dictionary<char, int>();

            foreach( var x in input)
            {
                if(countDict.ContainsKey(x))
                {
                    countDict[x]++;
                }
                else
                {
                    countDict.Add(x, 1);
                }
            }

            Console.WriteLine("Dictionary problem");

            foreach(var entry in countDict)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine("\nKeys");

            foreach (var key in countDict.Keys)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine("\nValues");
            foreach (var value in countDict.Values)
            {
                Console.Write(value + " ");
            }

            #endregion

            #region LISTS

            //Console.WriteLine("List of Names");

            //List<Person> thePeoeple = new List<Person> { helen, will };

            //foreach (var item in thePeoeple)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> myList = new List<int> { 5, 4, 3, 9, 0};

            //myList.Add(8);

            //myList.Sort();

            //myList.RemoveAt(1);
            //myList.RemoveAt(1);

            //int myListVal = myList[0];
            //myList.RemoveAt(0);
            //myList.Insert(1, myListVal);

            //myList.Reverse();
            //myList.Remove(9);

            //foreach(var item in myList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region QUEUE
            //QUEUE

            var myQueue = new Queue<Person>();

            myQueue.Enqueue(helen);
            myQueue.Enqueue(will);
            myQueue.Enqueue(new Person("Cathy", "Lovegood") { Age = 18 });

            foreach (var person in myQueue)
            {
                Console.WriteLine(person);
            }

            var first = myQueue.Peek();

            var howMany = myQueue.Count;

            var serve = myQueue.Dequeue();

            #endregion

            #region STACK
            //STACK
            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] reverserd = new int[original.Length];

            var stack = new Stack<int>();

            foreach (var n in original)
            {
                stack.Push(n);
                //Push on top of the stack
            }
            Console.WriteLine("\nStack\n");
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < original.Length; i++)
            {
                reverserd[i] = stack.Pop();
                //Remove from the stack
            }
            #endregion

            #region HASHET
            //HASHET

            var peopleSet = new HashSet<Person>
            { helen,
            new Person("Jasmine"),
            new Person("Andreia")
            };

            Console.WriteLine("HashSet");
            foreach (var entry in peopleSet)
            {
                Console.WriteLine(entry);
            }

            var successMartin = peopleSet.Add(new Person("Martin", "Beard") { Age = 2131 });
            var successHelen = peopleSet.Add(new Person("Helen", "Troy") { Age = 23 });

            var morePeople = new HashSet<Person> { new Person("Cathy") { Age = 23 }, new Person("Jasmine") };

            peopleSet.IntersectWith(morePeople);
            //removes everything from peopleSet that doesn't match with morePeople


            var vehicleSet = new HashSet<Vehicle>
            {
                new Vehicle{NumPassengers = 3, Speed = 2},
                new Vehicle{Speed = 100}
            };

            var success = vehicleSet.Add(new Vehicle { Speed = 100 });

            #endregion

            //Console.WriteLine(nish.CameraName()); // SafariPark.WasterPistol

            //var cannon = new Camera("Cannon");
            //var yolanda = new Person("Yolanda", "Young");
            //SpartaWrite(yolanda);
            //var martinHunter = new Hunter("Martin", "Beard", cannon) {Age = 43};
            //SpartaWrite(martinHunter);

            #region HunterWithDifferentGuns

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

            //Console.WriteLine("\n");

            //var bobOne = new Person("Bob", "Builder") { Age = 35 };
            //var bobTwo = bobOne;
            //var areSame = bobOne.Equals(bobTwo);

            //var bobThree = new Person("Bob", "Builder") { Age = 35 };
            //var areSameOneTree = bobOne.Equals(bobThree);


            //List<Person> personList = new List<Person>
            //{
            //    new Person("Cath", "Cookson"),
            //    new Person("Bob", "Builder"){Age=35},
            //    new Person("Dan", "Dare"),
            //    new Person("Amy", "Anderws"){Age = 32}
            //};

            //personList.Sort();

            //var hasBob = personList.Contains(bobOne);

            #endregion

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
