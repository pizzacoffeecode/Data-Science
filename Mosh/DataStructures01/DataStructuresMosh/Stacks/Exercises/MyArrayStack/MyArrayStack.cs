using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh.Stacks.Exercises.MyArrayStack
{
    public class MyArrayStack
    {
        public int[] stack 
        {
            get; set;
        }
        public int count;

        public MyArrayStack(int size = 1)
        {
           this.stack = new int[size];
        }

        public void Push(int value)
        {
            int[] temp_stack = new int[stack.Length + 1];
            Console.WriteLine("Stack Size : " + temp_stack.Length);
            stack.CopyTo(temp_stack, 1);
            stack = temp_stack;
            stack[0] = value;
        }

        public void Print(int[] stack)
        {
            for (int i = 0; i < stack.Length; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create stack class
            MyArrayStack stack = new MyArrayStack();

            stack.Push(3);
            stack.Print(stack.stack);


            //Push
            //pop
            //peek

            //isEmpty

            //int[]

        }
    }
}
