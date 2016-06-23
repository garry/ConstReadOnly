using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationConstReadOnly
{
    class Program
    {

        readonly int j = 3;//readonly field can be initialized either at time of declaration or within constructor of same class.
        //Explicitly, u can specify a readonly field as static.
        //readonly can be applied to value type and reference type.
        //Use readonly modifier when u want to make a field constant at runtime.
        
        internal const int i = 1;//constant fields must be asigned a value at the time of declaration and after that they cannot be modified.
        //By default const are static hence u cannot define const as static.
        //A constant field can be initialized with a constant expression which must be fully evaluated at compile time.
        //All access modifiers are applicable on const.
        //Use const modifier when u sure that value of field would not be changed.
        
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("i=" + i + 2);
            Console.WriteLine("j=" + p.j);
            Console.ReadLine();

        }
         void Calculate(int z)
        {
            const int x = 10, a = 20;
            const int y = x + a;//Correct
            //const int b = x + z;//Compile time Error becoz z is evaluated at runtime

        }
        public Program()
        {

            j = 2;
            
        }
    }
}
