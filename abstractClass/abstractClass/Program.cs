using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    abstract class Seasons
    {
        public abstract void quote();
        public abstract void quote2();
    }
    class Summer : Seasons{
        public override void quote()
        {
           Console.WriteLine("Hello I am from Suumer");
        }
        public override void quote2()
        {
            Console.WriteLine("Hello I am  Suumer from quote2");
        }
    }
    class Winter : Seasons
    {
        public override void quote()
        {
            Console.WriteLine("Hello I am from winter");
        }
        public override void quote2()
        {
            Console.WriteLine("Hello I am Winter from quote2");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Summer summ = new Summer();
            summ.quote();
            summ.quote2();
            Winter win = new Winter();
            win.quote();
            win.quote2();
        }
    }
}

