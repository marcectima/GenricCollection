using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Colors = new List<string>();
            Colors.Add("Purple");
            Colors.Add("Blue");
            Colors.Add("Green");
            Colors.Add("Yellow");
            Colors.Add("Red");

            foreach (string Color in Colors)
            {
                Console.WriteLine("List: " + Color);
            }

            LinkedList<string> WildCats = new LinkedList<string>();
            WildCats.AddLast("Lions");
            WildCats.AddLast("Tigers");
            WildCats.AddLast("Leopard");
            WildCats.AddLast("Cheetah");
            WildCats.AddLast("Panther");

            foreach (string WildCat in WildCats)
            {
                Console.WriteLine("LinkedList: " + WildCat);
            }

            Queue<string> Transportations = new Queue<string>();
            Transportations.Enqueue("Car");
            Transportations.Enqueue("Air Plane");
            Transportations.Enqueue("Boat");
            Transportations.Enqueue("Train");
            Transportations.Enqueue("Truck");

            foreach (string Transportation in Transportations)
            {
                Console.WriteLine("Queue: " + Transportation);
            }

            Stack<string> Buildings = new Stack<string>();
            Buildings.Push("Church");
            Buildings.Push("Library");
            Buildings.Push("School");
            Buildings.Push("Hospital");
            Buildings.Push("Fire Department");

            foreach (string Building in Buildings)
            {
                Console.WriteLine("Stack: " + Building);
            }

            Dictionary<string, string> Sports = new Dictionary<string, string>();
            Sports.Add("Basketball", "NBA");
            Sports.Add("Football", "NFL");
            Sports.Add("Baseball", "MLB");
            Sports.Add("Hockey", "NHL");
            Sports.Add("Soccer", "MLS");

            foreach (KeyValuePair<string, string> Sport in Sports)
            {
                Console.WriteLine("Dictionary: " + Sport);
            }

            SortedList<string, string> Jobs = new SortedList<string, string>();
            Jobs.Add("Fire Department", "Fire Fighter");
            Jobs.Add("Police Department", "Police");
            Jobs.Add("Hospital", "Doctor");
            Jobs.Add("School", "Teacher");
            Jobs.Add("Restaurant ", "Chief");

            foreach ( KeyValuePair<string, string> Job in Jobs)
            {
                Console.WriteLine("SortedList: " + Job);
            }

            HashSet<string> Cables = new HashSet<string>();
            Cables.Add("Comcast");
            Cables.Add("Spectrum");
            Cables.Add("XFinity");
            Cables.Add("AT&T");
            Cables.Add("Optimum");

            foreach (string Cable in Cables)
            {
                Console.WriteLine("HashSet: " + Cable);
            }

            Console.ReadKey();
        }
    }
}