using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh.Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyLinkedList();

            Console.WriteLine("the Linked List is of size {0}", list.Size());
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.Print();
            Console.WriteLine("The item you searched for is index {0}", list.IndexOf(70));
            Console.WriteLine("the Linked List is of size {0}", list.Size());
            Console.WriteLine("Item in Linked List = {0}", list.Contains(20));
            list.RemoveLast();
            list.Print();
            Console.WriteLine("the Linked List is of size {0}", list.Size());
            var array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("copied array item {0} = {1}", i, array[i]);
            }
        }

    }

    class MyLinkedList  // Mosh Version
    {
        private class Node
        {
            protected internal int value
            {
                get; set;
            }
            protected internal Node next
            {
                get; set;
            }

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last;
        private int size;

        //----------------

        // addFirst (6)
        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (isEmpty())
            {
                first = last = node;        // This syntax is cool, intitializes both variabls to node
            }
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }

        // addLast  (5)
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (first == null)
                first = last = node;
            else
            {
                last.next = node;   // set existing last nodes.next to point at this new node
                last = node;        // Give the new node the last title, instead of the old last node - vid 5
            }
            size++;
        }

        // RemoveFirst (9)
        public void RemoveFirst()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            if (first == last)
                first = last = null;
            else
            {
                var second = first.next;        // <-- This is better than my way 
                first.next = null;
                first = second;
            }
            size--;
        }

        // RemoveLast 10
        public void RemoveLast()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            if (first == last)
                first = last = null;
            else
            {
                var previous = GetPrevious(last);
                Console.WriteLine("The last node '{0}' was removed", last.value);
                last = previous;
                last.next = null;
            }
            size--;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)     // Meaning we haven't reached the end of the list
            {
                if (current.next == node)
                    return current;
                current = current.next;
            }
            return null;
        }

        // contains (8)
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        // indexOf (7)
        public int IndexOf(int item)       //  This is qaulity, this is to iterate over an object that is not an enumerator or has no index
        {
            int index = 0;
            var current = first;
            while (current != null)        // Meaning we haven't reached the end of the list
            {
                if (current.value == item)
                    return index;
                current = current.next;    // no need to write else
                index++;
            }
            return -1;                     // just a flag that is used in contains above. It literally returns -1
        }

        //Size
        public int Size()
        {
            return size;
        }

        //ToArray
        public int[] ToArray()
        {
            int[] array = new int[size];
            var current = first;
            int index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }

        // Print (i did this)
        public void Print()
        {
            var current = first;

            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        private Boolean isEmpty()
        {
            return first == null;
        }
    }
}
