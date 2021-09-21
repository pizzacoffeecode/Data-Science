//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructuresMosh.Stacks.Exercises
//{
//    public class ArrayStack
//    {
//        private int[] items = new int[5];
//        private int count;

//        public void Push(int item)
//        {
//            if (count == items.Length)
//                throw new StackOverflowException();

//            items[count++] = item;
//        }

//        public int Pop()
//        {
//            if (count == 0)
//                throw new InvalidOperationException();  // Thow invalid op ex if the user tries to pop an empty stack

//            return items[--count];
//        }

//        public int Peek()
//        {
//            if (count == 0)
//                throw new InvalidOperationException();  // Thow invalid op ex if the user tries to pop an empty stack

//            var item = items[count -1];                    
//            Console.WriteLine($"You peeked {item}");
//            return item;
//        }

//        public bool isEmpty()
//        {
//            return count == 0;
//        }
//        public void Print()
//        {
//            var content = new int[count];
//            for (int i = 0; i < content.Length; i++)
//            {
//                content[i] = items[i];
//            }
//            items = content;
//            Console.WriteLine(string.Join(",", items));
//        }
//    }


//    class Program
//    {
//        static void Main()
//        {   // How it works
//            // [10,0,0,0,0]             [10,20,0,0,0]
//            // count = 1                count = 2
//            // push(10)                 push(20)
//            // array[count] = 10        array[count] = 20           Use count variable to determine where end of stack is

//            ArrayStack stack = new ArrayStack();
//            stack.Push(10);
//            stack.Push(20);
//            stack.Push(30);
//            stack.Print();
//            stack.Pop();
//            stack.Peek();
//            stack.Print();
//        }
//    }
//}