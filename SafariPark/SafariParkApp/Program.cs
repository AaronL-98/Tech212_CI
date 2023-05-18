using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class noun Pascal
            // Feild Noun private _underScoreCamel
            // Properties Noun Public PascalCase


            //--PERSON CLASS--
            //Person joe = new("Joe", "mcCann", 25);
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine(joe.FullName);
            //Person nish = new("Nish", "Mandal");
            //Console.WriteLine(nish.FullName);
            //Person lemon = new("Lemon");
            //Console.WriteLine(lemon.FullName);
            //Person lime = new("lLime", "Lime");
            //lime.Age = 3;
            //Console.WriteLine(lime.Age);
            //var alex = new Person("Alex", "Blunt") { Age = 31 };

            //--SHOPPING LIST--
            //var list = new ShoppingList() { Bread = 3, Potato = 6, Milk = 2};
            //ShoppingList list2 = new() { Bread = 3, Potato = 6, Milk = 2 };
            //Point3D p = new Point3D(3, 6, 2);
            //var p2 = new Point3D();
            //Point3D p3;
            //Point3D p4 = new Point3D( 1, 7);
            //Person akito = new Person("Akito", "Oyama") { Age = 20 };
            //Point3D pt3D = new Point3D(5, 8, 2);
            //DemoMethod(pt3D, akito);
            //Vehicle v1 = new();
            //Vehicle v2 = new(4, 40);
            //Hunter h = new("lemon", "lime", "Tweet") { Age = 32 };
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());
            //var h2 = new Hunter("lemon", "lime", "Tweet") { Age = 32 };
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h HashCode: {h.GetHashCode}");
            //Console.WriteLine($"h Type: {h.GetType()}");
            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h: {h}");

            //--Shapes --
            //Rectangle rect = new(3, 4);
            //Console.WriteLine(rect);

            //--Airplane Exercise--
            //Airplane a = new Airplane(200, 100, "JetsRUs"){ NumPassengers = 150};
            //a.Ascend(500); 
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200); 
            //Console.WriteLine(a.Move()); 
            //a.Move();
            //Console.WriteLine(a);

            //--Polymorthism--
            //List<Object> gameObjects = new()
            //{
            //    new Person("Cathy", "French"),
            //    //new Hunter("Stephano", "Naressi", ),
            //    new Vehicle()
            //};
            //foreach (var gameObj in gameObjects)
            //{
            //    Console.WriteLine(gameObj);
            //}
            //SpartaWrite(gameObjects[0]);
            //List<IMovable> movable = new()
            //{
            //    new Person("Cathy", "French"),
            //    //new Hunter("Stephano", "Naressi"),
            //    new Vehicle(5, 10),
            //    new Airplane(200, 100, "JFly")
            //};
            //foreach(var elem in movable)
            //{
            //    Console.WriteLine(elem.Move());
            //    Console.WriteLine(elem.Move(2));
            //}

            //--Polymorphic Shootout--
            //Camera lego = new("Loglas");
            //List<IShootable> gunRack = new()
            //{
            //    new WaterPistol("SuperSoaker"),
            //    new LaserGun("Acme"),
            //    new WaterPistol("FloodRipper"),
            //    new LaserGun("PewThing"),
            //    new Hunter("Lemon", "Lime", lego),
            //};
            //foreach(var gun in gunRack)
            //{
            //    Console.WriteLine(gun.Shoot());
            //}
            //Console.WriteLine("Polymorphic Shootout!!!!! START!");
            //Camera pentax = new Camera("Pentax");
            //WaterPistol pistol = new WaterPistol("SuperSoaker");
            //LaserGun laserGun = new LaserGun("Acme");
            //Hunter nish = new Hunter("Nish", "Mandal", pentax);
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol;
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = laserGun;
            //Console.WriteLine(nish.Shoot());
            //nish.Shooter = pistol;
            //Console.WriteLine(nish.Shoot());

            //--Object Equality--
            //var robOne = new Person("Robert", "Sponge") { Age = 26 };
            //var robTwo = robOne;
            //var areSame = robOne.Equals(robTwo); // True - Via memory adress
            //var robThree = new Person("Robert", "Sponge") { Age = 26 };
            //areSame = robOne.Equals(robThree); // False - Diferent Memory Locations
            //List<Person> personList = new List<Person>
            //{
            //    new Person("Bobert", "Sponge"),
            //    new Person("Sandy", "Cheeks"){Age = 25},
            //    new Person("Robert", "Sponge"){Age = 28},
            //    new Person("Robert", "Sponge"){Age = 26},
            //    new Person("Squilliam", "Squid"){Age = 32}
            //};
            //foreach(var person in personList)
            //{
            //    Console.WriteLine(person);
            //}
            //var hasRob = personList.Contains(robOne); // False - Different Memory Locations
            //var equls = robOne == robThree;
            //var notEquals = robOne != robThree;
            //personList.Sort();
            //Console.WriteLine();
            //foreach (var person in personList)
            //{
            //    Console.WriteLine(person);
            //}

            //--Collections--
            var helen = new Person("Helen", "Troy") { Age = 22 };
            var will = new Hunter("William", "Shakespeare", new Camera("McBeth")) { Age = 457 };
            Console.WriteLine("List of People");
            List<Person> thePeople = new() { helen, will };
            foreach (var item in thePeople)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<int> numList = new() { 5, 4, 3, 9, 0 };
            numList.Add(8);
            numList.Sort();
            numList.RemoveRange(1, 2);
            numList.Insert(2, 1);
            numList.Reverse();
            numList.Remove(9);
            numList.ForEach(delegate(int i){ Console.Write(i);});

            LinkedList<Person> linkedPeopleList = new();
            var firstNode = linkedPeopleList.AddFirst(helen);
            linkedPeopleList.AddLast(will);
            linkedPeopleList.AddLast(new Person("Lime", "Tree") { Age = 90 });
            var john = new Person("John", "Green", 3);
            linkedPeopleList.AddAfter(linkedPeopleList.Find(will), john);

            var myQueue = new Queue<Person>();
            myQueue.Enqueue(helen);
            myQueue.Enqueue(will);
            myQueue.Enqueue(new Person("Cull", "Lemons"));
            Console.WriteLine("\nQueue");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            var first = myQueue.Peek();
            var serve = myQueue.Dequeue();

            int[] origi = new int[] { 1, 2, 3, 4, 5 };
            int[] rev = new int[origi.Length];
            var stack = new Stack<int>();

            Console.WriteLine("\n Stack");
            foreach (var item in origi)
            {
                stack.Push(item);
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < origi.Length; i++)
            {
                Console.WriteLine(stack.Peek());
                rev[i] = stack.Pop();
            }

            var peopleSet = new HashSet<Person>()
            {
                helen, new Person("Jasmine"), new Person("Andrei")

            };
            Console.WriteLine("HashSet");
            foreach (var item in peopleSet)
            {
                Console.WriteLine(item);
            }

            var successMartin = peopleSet.Add(new Person("Martin", "Beard", 60));
            var sussessHellen = peopleSet.Add(new Person("Helen", "Troy") { Age = 22 });

            var morePeople = new HashSet<Person> { new Person("Cathy"), new Person("Jasmine") };
            //--Research--
            // UnionWith, InSubsetOf, Overlaps, SetEquals

            var personDict = new Dictionary<string, Person>
            {
                {"helen", helen},
                { "sherlock", new Person("Sherlock", "Jones"){Age = 40} }
            };
            var p = personDict["sherlock"];
            personDict.Add("will", will);

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (countDict.ContainsKey(c)) countDict[c]++;
                else countDict.Add(c, 1);
            }
            Console.WriteLine("Dicionary Problem");
            foreach (var item in countDict)
            {
                Console.WriteLine(item);
            }
        }

        public static void SpartaWrite(Object i)
        {
            Console.WriteLine(i.ToString());
            if (i is Hunter)
            {
                var hunterObj = (Hunter)i;
                Console.WriteLine(hunterObj.Shoot());
            }
        }


        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }

    }
}