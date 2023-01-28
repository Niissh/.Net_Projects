using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class calc
    {
        int num1, num2, sum, sub, mul;
        float div;   
        public void getnum()
        {
            Console.Write("Enter num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        private void dosum()
        {
            sum = num1 + num2;
        }
        private void dosub()
        {
            sub = num1 - num2;
        }
        private void domul()
        {
            mul = num1*num2;
        }
        private void dodiv()
        {
            div = num1 / num2;
        }
        public void showresult()
        {
            dosum();
            dosub();
            domul();
            dodiv();
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, sub);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, mul);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, div);
        }
    }
    class program
    {


        static void Main(string[] args)
        {
            calc obj = new calc();
            obj.getnum();
            obj.showresult();
            Console.ReadKey();
        
           
           
            
        }
    }
}
