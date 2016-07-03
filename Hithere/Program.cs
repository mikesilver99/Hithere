using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hithere
{
    class Program
    {
        static void Main(string[] args)
        {
            foo();
        }

        static void foo()
        {
            Console.WriteLine("Hi from the master branch.");

            Console.WriteLine("This is a change I made in branch1.");
            int z = 56;
            int y = z + 1;

            //I'm making another change to my local master repository.
        }
    }
}
