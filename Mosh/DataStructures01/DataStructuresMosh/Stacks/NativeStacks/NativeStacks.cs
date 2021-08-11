using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Linq;

namespace DataStructuresMosh.Stacks.NativeStacks
{
    public class NativeStacks
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Print(stack, "Numbers pushed to stack");

            Console.WriteLine("Popping {0}", stack.Peek());
            stack.Pop();

            Console.WriteLine("Peeking next number : {0}", stack.Peek());

            void Print(Stack<int> _stack, string message = "")
            {
                foreach (int item in _stack)
                {
                    Console.WriteLine(message + " " + item);
                }
            }
        }
    }
}
