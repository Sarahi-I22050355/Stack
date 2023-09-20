using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Element at the top of the stack: " + stack.Peek());

            Console.WriteLine("Popping elements:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadKey();
        }
    }
}
