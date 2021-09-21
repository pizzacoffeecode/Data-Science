using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresMosh.Queues
{
    public class QueueWithTwoStacks
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        // O(1)
        public void Enqueue(int item)
        {
            stack1.Push(item);
            Console.WriteLine($"Pushed : {item}");
        }

        // O(n)
        public int Dequeue()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            MoveStack1ToStack2();

            Console.WriteLine($"Popped : {stack2.Peek()}");
            return stack2.Pop();
        }

        private void MoveStack1ToStack2()
        {
            if (stack2.Count == 0)
                while (stack1.Count != 0)
                    stack2.Push(stack1.Pop());
        }

        public int Peek()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            MoveStack1ToStack2();

            Console.WriteLine($"Peek : {stack2.Peek()}");
            return stack2.Peek();
        }

        public bool isEmpty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }
    }

    class Program
    {
        static void Main()
        {
            var queue = new QueueWithTwoStacks();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            queue.Peek();
        }
    }
}
