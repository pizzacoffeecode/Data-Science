using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresMosh.Queues
{
    class Program
    {
        static void Main()
        {
            ArrayQueue queue = new ArrayQueue(5);
            Debug(queue);
            queue.enqueue(10);

            Debug(queue);

            queue.enqueue(20);
            Debug(queue);
            queue.enqueue(30);
            Debug(queue);
            queue.enqueue(40);
            Debug(queue);
            queue.enqueue(50);

            queue.Print();
            Debug(queue);

            queue.dequeue();
            queue.dequeue();

            queue.enqueue(60);
            queue.enqueue(70);
            queue.dequeue();
            queue.enqueue(80);

            queue.Print();
            Debug(queue);

            queue.dequeue();
            queue.Print();
            Debug(queue);

            static void Debug(ArrayQueue queue)
            {
                Console.WriteLine($"Front Index = {queue.Front}");
                Console.WriteLine($"Front Value = {queue.items[queue.Front]}");
                Console.WriteLine($"Rear Index = {queue.Rear}");
                Console.WriteLine($"Rear Value = {queue.items[queue.Rear]}");
            }
        }
    }
    public class ArrayQueue
    {
        public int[] items
        {
            get; set;
        }
        public int Rear
        {
            get; set;
        }
        public int Front
        {
            get; set;
        }
        public int Count
        {
            get; set;
        }
        public ArrayQueue(int capacity)
        {
            items = new int[capacity];                  // Set queue capacity in constructor
        }
        public void enqueue(int item)                   // Visualize the back of the queue to the right, not left
        {
            if (isFull())                               // Err if the queue is full
                throw new InvalidOperationException();  

            items[Rear] = item;                         // sets the newly added item (say 10 ) to the back [15, 12, 10, 0, 0, 0]
                                                        //                                                  F        R          <-- Pointers
            Rear = (Rear + 1) % items.Length;           // Cicular Array Code - The items array is 5 so when rear is index 4...4+1 = 5....5%5 = 0 | ...5+1=6...6%5 is 1....6%5=2 etc..
                                                                                        //        
            Console.WriteLine($"enqueued : {item}");
            Count++;                                    //                                                  
        }                                               // Incremements the 'pointer' to Rear to the next position      R

        public int dequeue()
        {
            if (isEmpty())                              // Err if the queue is full
                throw new InvalidOperationException();

            var item = items[Front];                    // Store the value of the index to be removed for the return of the fuction
                                        
            items[Front] = 0;                           // Now that it is stored in the temp var above, set it to 0 since it is being removed
            Front = (Front + 1) % items.Length;         // Circular Array Code to move the index of the front pointer to the next position if
            Count--;                                    // decrement count since we dequed an item
            Console.WriteLine($"dequeued : {item}");
            return item;                                // Return the origial value before the increment operation
        }

        public void Print()
        {
            var content = new int[items.Length];
            for (int i = 0; i < content.Length; i++)
            {
                content[i] = items[i];
            }
            items = content;
            Console.WriteLine(string.Join(",", items));
        }

        public bool isEmpty()
        {
            return Count == 0;
        }

        public bool isFull()
        {
            return Count == items.Length;
        }
    }
}
