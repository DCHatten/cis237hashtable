using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating a Generic Hash Class from this library
            GenericHashMap<int, string> valleyNumToName = new GenericHashMap<int, string>();
            //This is the built in C# Hash Class
            Dictionary<int, string> valleyNumToNameDictionary = new Dictionary<int, string>();
            //Setting the screen size
            Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("EX: valleyNumToName.Put(45678, \"Jean-Luc Picard\")");

            valleyNumToName.Put(12345, "James Kirk");
            valleyNumToName.Put(23456, "Benjamin Sisko");
            valleyNumToName.Put(34567, "Kathryn Janeway");
            valleyNumToName.Put(45678, "Jean-Luc Picard");
            valleyNumToName.Put(56789, "Jonathan Archer");

            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("valleyNumToName.Get(45678)");
            Console.WriteLine(valleyNumToName.Get(45678));
            Console.WriteLine("**************************************************");
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.WriteLine();
            
            //Print the Hash table and array
            Console.WriteLine("The Created Hash Table");
            Console.WriteLine(valleyNumToName.ToString());
            Console.WriteLine();
            Console.WriteLine("The full array as it got filled out");
            Console.WriteLine(valleyNumToName.ShowArrays());
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("**************************************************");
            Console.WriteLine("Add some entries using the C# Dictionary");
            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("EX: valleyNumToNameDictionary.Add(45678, \"Jean-Luc Picard\")");

            valleyNumToNameDictionary.Add(12345, "James Kirk");
            valleyNumToNameDictionary.Add(23456, "Benjamin Sisko");
            valleyNumToNameDictionary.Add(34567, "Kathryn Janeway");
            valleyNumToNameDictionary.Add(45678, "Jean-Luc Picard");
            valleyNumToNameDictionary.Add(56789, "Jonathan Archer");

            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("valleyNumToNameDictionary.TryGetValue(45678)");
            string theValueIWant;
            valleyNumToNameDictionary.TryGetValue(45678, out theValueIWant);
            Console.WriteLine(theValueIWant);
            Console.WriteLine("**************************************************");
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.WriteLine();

            //Print the Hash table and array
            Console.WriteLine("The Created Hash Table");
            var theArray = valleyNumToNameDictionary.ToArray();
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine("[" + i + "] - " + " => " + theArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("**************************************************");
            Console.WriteLine("What if we add 2 entries to the hash table");
            Console.WriteLine("that map to the same location?");
            Console.WriteLine("valleyNumToName.Put(26189, \"First Entry\")");
            valleyNumToName.Put(26189, "First Entry");
            Console.WriteLine("valleyNumToName.Put(26092, \"Second Entry\")");
            valleyNumToName.Put(26092, "Second Entry");
            Console.WriteLine();
            Console.WriteLine("Let's try to get out the first entry");
            Console.WriteLine("It should not exist since it was overwritten");
            Console.WriteLine("by the second entry.  Therefore retrieving");
            Console.WriteLine("the first will actually return the second.");
            Console.WriteLine();
            Console.WriteLine("valleyNumToName.Get(26189)");
            Console.WriteLine(valleyNumToName.Get(26189));
            Console.WriteLine("**************************************************");
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("**************************************************");
            Console.WriteLine("What if we add 2 entries to the C# Dictionary");
            Console.WriteLine("that map to the same location?");
            Console.WriteLine("valleyNumToNameDictionary.Add(26189, \"First Entry\")");
            valleyNumToNameDictionary.Add(26189, "First Entry");
            Console.WriteLine("valleyNumToNameDictionary.Add(26092, \"Second Entry\")");
            valleyNumToNameDictionary.Add(26092, "Second Entry");
            Console.WriteLine();
            Console.WriteLine("Let's try to get out the first entry");
            Console.WriteLine("It should not exist since it was overwritten");
            Console.WriteLine("by the second entry.  Therefore retrieving");
            Console.WriteLine("the first will actually return the second.");
            Console.WriteLine();
            theArray = valleyNumToNameDictionary.ToArray();
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine("[" + i + "] - " + " => " + theArray[i]);
            }
            Console.WriteLine("valleyNumToNameDictionary.TryGetValue(26189)");
            valleyNumToNameDictionary.TryGetValue(26189, out theValueIWant);
            Console.WriteLine(theValueIWant);
            Console.WriteLine("**************************************************");
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
