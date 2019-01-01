using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.ScareLittleChildren();
            someOtherScaryClown.Honk();
            Console.WriteLine(someOtherScaryClown.ScaryThingIHave);
            Console.ReadKey();
        }
    }
}
