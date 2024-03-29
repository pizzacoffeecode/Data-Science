﻿using System;
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
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            list.AddLast(70);
            list.AddLast(80);
            list.AddLast(90);
            list.AddLast(100);
            list.Print();
            // Console.WriteLine("The item you searched for is index {0}", list.IndexOf(70));
            // Console.WriteLine("the Linked List is of size {0}", list.Size());
            // Console.WriteLine("Item in Linked List = {0}", list.Contains(20));
            // list.RemoveLast();
            // list.Print();
            Console.WriteLine("the Linked List is of size {0}", list.Size());
            var array = list.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("copied array item {0} = {1}", i, array[i]);
            }
            list.getKthFromTheEnd(3);

            list.Reverse();
            var ReverseArray = list.ToArray();
            for (int i = 0; i < ReverseArray.Length; i++)
            {
                Console.WriteLine("Reversed array item {0} = {1}", i, ReverseArray[i]);
            }
            list.getKthFromTheEnd(5);

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
            protected internal Node next    // 
            {
                get; set;
            }

            public Node(int value)          // constructor
            {
                this.value = value;         // initialize data
            }
        }

        private Node first;                 // first node   
        private Node last;                  // last node  
        private int size;                   // number of nodes in list

        //----------------

        // addFirst (6)
        public void AddFirst(int item)      // add item to front of list
        {
            var node = new Node(item);      // create a new node
            if (isEmpty())                  // if list is empty
            {
                first = last = node;        // This syntax is cool, intitializes both variabls to node
            }
            else
            {
                node.next = first;          // This is not declaring node.next as 'first', it is saying the next node is the node called first
                first = node;               // NOW we are declaring this new node as 'first'
            }
            size++;
        }

        // !!! INTERVIEW QUESTION
        // getKthFromTheEnd (18/19)
        public int getKthFromTheEnd(int k)              // k is the value from the end
        {
            // if(isEmpty() || k > size) return -1;     | This works, but in interview they may say we don't know size of linklist, moved to for loop
            if (isEmpty())
                throw new ArgumentException();

            Node firstRef = first;                      // Create two references nodes at the 'first' node
            Node secondRef = first;
            for (int i = 0; i < k - 1; i++)             // Create an offset of 'k' spaces between first and second node
            {
                secondRef = secondRef.next;             // i.e. if k = 3 (remember -1) and linklist size 6     ... [F] [] [S] [] [] []
                if (secondRef == null)
                    throw new ArgumentException();
            }
            while (secondRef != last)                   // Offset is maintained
            {
                firstRef = firstRef.next;
                secondRef = secondRef.next;
            }
            Console.WriteLine("The kth from the end is {0}", firstRef.value);
            return firstRef.value;
        }


        // !!! INTERVIEW QUESTION
        // Linked Lists V.17 if you don't understand
        // BEFORE LOOP
        // Previous(P) = first
        // Current(C) = first.next

        //IN WHILELOOP
        // 1)
        // [First]                                        [Last]
        // [10          ->          20          ->          30]
        //  P                       C	
        //						                       Next = C.Next
        //  C.Next = P  <-	        C		    ->                                             // Notice reference <- changed direction
        //

        // 2)	
        //              Node        P                        C
        //					                                                C.Next = Null
        //              <-          C.Next = P	<-           C	

        // 3)           <-          Node        <-           C.Next = P     Current = Null	
        // ...Current is now equal to null so break out of the while loop

        // [Last = First]
        // Remove old 'reference' to last.next (->) by setting last.next = null
        // 						                             [First] = P                    

        public void Reverse()               
        {                                   
            if (isEmpty())                  
                return;            
            var previous = first;               
            var current = first.next;            
                                                                         
            while (current != null)
            {
                var next = current.next;    
                current.next = previous;    
                previous = current;         
                current = next;             
            }                              
                                                                                                                                         
            last = first;                                                                            
            last.next = null;               
            first = previous;               
        }                                                               

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
            if (first == last)                      // if only one node in list
                first = last = null;                // set both nodes to null
            else                                    // if more than one node in list
            {
                var second = first.next;            // save the second node
                first.next = null;                  // break the link between the first node and the next node
                first = second;                     // set the first node to the second node
            }
            size--;                                 // decrement the size of the list
        }

        // RemoveLast 10
        public void RemoveLast()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
            if (first == last)
                first = last = null;                // if only one node in list
            else
            {
                var previous = GetPrevious(last);   // save the previous node of the last node
                Console.WriteLine("The last node '{0}' was removed", last.value);
                last = previous;                    // set the last node to the previous node
                last.next = null;
            }
            size--;
        }

        private Node GetPrevious(Node node)         // get previous node
        {
            var current = first;                    // start at the first node
            while (current != null)                 // Meaning we haven't reached the end of the list
            {
                if (current.next == node)           // If the current node is the node we want
                    return current;
                current = current.next;             // Go to the next node
            }
            return null;
        }

        // contains (8)
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;    // See below... 
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
            int[] array = new int[size];            // create an array of the right size
            var current = first;
            int index = 0;
            while (current != null)                 // Meaning we haven't reached the end of the list
            {
                array[index++] = current.value;     // add the value of the current node to the array
                current = current.next;             // go to the next node
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
            return first == null;                    // if first is null, return true
        }
    }
}
