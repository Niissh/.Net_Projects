using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
   class Program
    {
        static void Main()
        {
            //Creating a Generic List of string type
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA"
            };
            Console.WriteLine("Accessing List Elements Before Inserting");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Insert Element at Index Position 1
            countries.Insert(1, "China");
            Console.WriteLine("\nIndex of China Element in the List :"+ countries.IndexOf("China"));
            
	    //Accessing List After Insert Method
            Console.WriteLine("\nAccessing List After Inserting China At Index 1");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            
            //Creating Another Generic List Collection of string type
            List<string> newCountries = new List<string>
            {
                "JAPAN",
                "UK"
            };
            
            //Inserting the newCountries collection into the existing countries list at Index 2 using                    InsertRange Method
            countries.InsertRange(2, newCountries);
            
            //Accessing countries List After InsertRange Method
            Console.WriteLine("\nAccessing List After InsertRange At Index 2");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
