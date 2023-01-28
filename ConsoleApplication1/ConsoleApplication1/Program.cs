using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Enrollment Number");
            int Enroll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of the Student: " + Name);
            Console.WriteLine("Name of the Student: " + Enroll);
            Console.ReadKey();

        }
    }
}