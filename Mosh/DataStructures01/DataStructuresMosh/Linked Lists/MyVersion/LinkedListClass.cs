using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace DataStructuresMosh
{
    class LinkedListClass : IEnumerable<int>
    {
        static void Main(string[] args)
        {
            //
            // Create a new linked list object instance.
            //
            LinkedList<int> list = new LinkedList<int>();

            //
            // Use AddLast method to add elements at the end.
            // Use AddFirst method to add element at the start.
            //
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            list.AddFirst(5);
            list.AddFirst(10);
            list.RemoveLast();

            Console.WriteLine("The list contains {0}", list.Contains(10));


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
