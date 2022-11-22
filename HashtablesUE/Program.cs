using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1:

            Console.WriteLine("Aufgabe 1");
            IlibHashtable<string, string> Hashtable = new libHashtable<string, string>();
            Hashtable.put("erster", "Das");
            Console.WriteLine(Hashtable.Alpha);
            Hashtable.put("zweiter", "ist");
            Console.WriteLine(Hashtable.Alpha);
            Hashtable.put("dritter", "der");
            Console.WriteLine(Hashtable.Alpha);
            Hashtable.put("vierter", "Schuh");
            Console.WriteLine(Hashtable.Alpha);
            Hashtable.put("fünfter", "des");
            Console.WriteLine(Hashtable.Alpha);
            Hashtable.put("sechster", "Manitu");
            Console.WriteLine(Hashtable.Alpha);


            Console.WriteLine("get-Example for wrong: key: asd  value: " + Hashtable.get("asd"));
            Console.WriteLine($"get-Example for right: key: sechster  value:" + Hashtable.get("sechster"));
            Hashtable.put("sechster", "Überschrieben?");
            Console.WriteLine($"get-Example for right: key: sechster  value:" + Hashtable.get("sechster"));
            Hashtable.remove("asd");
            Console.WriteLine(Hashtable.Alpha.ToString());
            Console.WriteLine("Nächste Aufgabe Enter:");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Aufgabe 2");
            //Aufgabe 2:

            Person p1 = new Person("Albert", "Zuhause", 54);
            Person p2 = new Person("Bastian", "Deutschland", 41);
            Person p3 = new Person("Bastian", "Deutschland", 41);
        
            p3.GetHashCode();

            Console.WriteLine("Person 1 entspricht Person 2:" + p3.Equals(p1));
            Console.WriteLine("Person 1 entspricht Person 2:" + p3.Equals(p2));

            IlibHashtable<Person, string> HashtableP = new libHashtable<Person, string>();
            HashtableP.put(p1, p1.Name);
            HashtableP.put(p2, p2.Name);
            HashtableP.put(p3, p3.Name);

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(HashtableP.get(p1));
            p1.Age = 23;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(HashtableP.get(p1));

            Console.ReadLine();
        }
    }
}
