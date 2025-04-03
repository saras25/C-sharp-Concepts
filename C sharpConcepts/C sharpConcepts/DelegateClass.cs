using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharpConcepts
{
    //Step 1: Define a delegate
    public delegate void AddDelegates(int a, int b);

    //define a delegate for anonymous method
    public delegate void PrintMessage(string mssg);
    public class DelegateClass
    {
        public void AddNum(int a, int b)
        {
           Console.WriteLine("Adding a number: " + (a + b));
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplying the numbers: " + (a * b));
        }

    }
}
