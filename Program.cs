using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationConstReadOnly
{
    class Program
    {

        readonly int j = 3;
        internal const int i = 1;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("i=" + i + 2);
            Console.WriteLine("j=" + p.j);
            Console.ReadLine();

        }
        public Program()
        {

            j = 2;
            
        }
    }
}
