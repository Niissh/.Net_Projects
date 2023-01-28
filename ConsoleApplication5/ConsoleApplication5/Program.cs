using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "United Kingdom" },
                { "USA", "United State of America" },
                { "IND", "India" },
                { "PAK", "Pakistan" },
                { "SL", "Srilanka" }
            };
            Console.WriteLine("Dictionary Elements Count Before Removing: "+dictionaryCountries.Count);
            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine("Key:{item.Key}, Value:"+item.Value);
            }
            // Remove element PAK from Dictionary Using Remove() method
            if (dictionaryCountries.ContainsKey("PAK"))
            {
                dictionaryCountries.Remove("PAK");
                Console.WriteLine("\nDictionary Elements Count After Removing PAK: "+dictionaryCountries.Count);
                foreach (var item in dictionaryCountries)
                {
                    Console.WriteLine("Key:"+item.Key," Value:"+item.Value);
                }
            }
            // Remove all Elements from Dictionary Using Clear method
            dictionaryCountries.Clear();
            Console.WriteLine("\nDictionary Elements Count After Clear:"+ dictionaryCountries.Count);
            Console.ReadKey();
        }
    }
}