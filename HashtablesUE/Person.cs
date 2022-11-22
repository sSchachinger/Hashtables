using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Street { get; set; }
        public int ID = 0;
        public Person(string name, string adresse, int alter)
        {
            ID = ID + 1;
            Name = name;
            Age = alter;
            Street = adresse;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = (Name != null ? Name.GetHashCode() : 0);
                result = (result * 397) ^ (Street != null ? Street.GetHashCode() : 0);
                result = (result * 397) ^ Age; // Link both values using bitwise XOR
                return result;
            }
        }

        public override bool Equals(object obj)
        {
            Person obj1 = obj as Person;
            return obj != null &&
                obj1.Name == this.Name &&
                obj1.Street == this.Street &&
                obj1.Age == this.Age; 
        }

    }
}
