using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresMosh.Queues
{
    // Create a new class called PriorityQueue
    // [1,3,4,7]
    // Insert(2)
    // We want to insert 2 here :   [1,(2),3,4,7]
    // Iterate from the back forwards 
    // Edge cases : empty, full, single item?

    //
    public class PriorityQueue
    {
        public int[] items = new int[5];
        public int count;
        public void Add(int item)
        {
            //Resize if full
            if (isFull())
            {
                var tempArr = new int[items.Length * 2];
                items.CopyTo(tempArr, 0);
                items = tempArr;

                //throw new InvalidOperationException();
            }

            // Lets say we want to add 3
            var i = ShiftItemsToInsert(item);
            items[i] = item;        
            count++;
        }

        private int ShiftItemsToInsert(int item)
        {
            int i;                                                  // Lets say count is at 4
            for (i = count - 1; i >= 0; i--)                        // here's our arr                   [1,2,4,5,0]
            {                                                       // Heres count -1 in the indx       [0,1,2,3  ]
                if (items[i] > item)                                // items[i] or items[3]             [1,2,4,5,0]
                    items[i + 1] = items[i];                        // So here 0 will become 5                   ^
                else
                    break;
            }
            return i + 1;                                           // When (items[i] > is not true    [1,2,3,4,5] 
        }                                                           //                                      ^          

        public void Remove()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException();
            }
            else
            {
                var del = items[--count];
                Console.WriteLine(del);
                items[count] = 0;                                 // Decrement count first because a count of 5 would be an index of 4
            }
        }

        public bool isEmpty()
        {
            return count == 0;
        }
        public bool isFull()
        {
            return count == items.Length;
        }

        public void Print()
        {
            var content = new int[items.Length];
            for (int i = 0; i < content.Length; i++)
            {
                content[i] = items[i];
            }
            Console.WriteLine(string.Join(",", content));
        }
    }

    class Program
    {
        static void Main()
        {
            var queue = new PriorityQueue();
            Console.WriteLine($"count = {queue.count}");
            queue.Print();
            queue.Add(5);
            queue.Add(3);
            queue.Add(6);
            queue.Add(1);
            queue.Add(8);
            queue.Add(7);
            queue.Add(9);


            queue.Print();

            while (!queue.isEmpty())
            {
                queue.Remove();
            }
            queue.Print();

            queue.Add(11);
            queue.Add(12);
            queue.Add(13);

            queue.Print();
        }
    }
}



