
//// FAILED DON'T USE THIS


//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructuresMosh.Linked_Lists
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var reverseList = new MyReverseLinkedList();

//            Console.WriteLine("the Linked List is of size {0}", reverseList.Size());
//            reverseList.AddLast(10);
//            reverseList.AddLast(20);
//            reverseList.AddLast(30);
//            reverseList.AddLast(40);
//            reverseList.AddLast(50);
//            reverseList.AddLast(60);
//            reverseList.AddLast(70);

//            reverseList.Print();
//            //Console.WriteLine("The item you searched for is index {0}", reverseList.IndexOf(70));
//            //Console.WriteLine("the Linked List is of size {0}", reverseList.Size());
//            //Console.WriteLine("Item in Linked List = {0}", reverseList.Contains(20));
//            //reverseList.RemoveLast();
//            //reverseList.Print();
//            //Console.WriteLine("the Linked reverseList is of size {0}", reverseList.Size());
//            var array = reverseList.ToArray();
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine("copied array item {0} = {1}", i, array[i]);
//            }

//            reverseList.Reverse();
//            reverseList.Print();
//            var reverseArray = reverseList.ToArray();
//            for (int i = 0; i < reverseArray.Length; i++)
//            {
//                Console.WriteLine("copied reverse array item {0} = {1}", i, reverseArray[i]);
//            }

//        }

//    }

//    class MyReverseLinkedList  // Mosh Version
//    {
//        private class Node
//        {
//            protected internal int value    
//            {
//                get; set;
//            }
//            protected internal Node next    
//            {
//                get; set;
//            }

//            protected internal Node previous
//            {
//                get; set;
//            }

//            protected internal Node start
//            {
//                get; set;
//            }

//            public Node(int value)          // constructor
//            {
//                this.value = value;         // initialize data
//            }
//        }

//        private Node start;                 // start of list    
//        private Node first;                 // first node   
//        private Node last;                  // last node  
//        private Node previous;              // previous node
//        private int size;                   // number of nodes in list

//        //----------------

//        // addFirst (6)
//        public void AddFirst(int item)      // add item to front of list
//        {
//            var node = new Node(item);      // create a new node
//            if (isEmpty())                  // if list is empty
//            {
//                first = last = node;        // This syntax is cool, intitializes both variabls to node
//            }
//            else
//            {       
//                first = node;   
//                first.next.previous = first;            
//            }
//            size++;
//        }

//        public void AddLast(int item)
//        {
//            var node = new Node(item);

//            if (first == null)
//                first = last = node;
//            else
//            {
//                last.next = node;   // set existing last nodes.next to point at this new node
//                previous = last;   // set previous node to this node
//                last.start = first;
//                last = node;        // Give the new node the last title, instead of the old last node - vid 5
//                last.previous = previous;
                
//            }
//            size++;
//        }

//        // RemoveFirst (9)
//        public void RemoveFirst()
//        {
//            if (isEmpty())
//            {
//                throw new InvalidOperationException("Sequence contains no elements");
//            }
//            if (first == last)                      // if only one node in list
//                first = last = null;                // set both nodes to null
//            else                                    // if more than one node in list
//            {
//                var second = first.next;            // save the second node
//                first.next = null;                  // break the link between the first node and the next node
//                first = second;                     // set the first node to the second node
//            }
//            size--;                                 // decrement the size of the list
//        }

//        // RemoveLast 10
//        public void RemoveLast()
//        {
//            if (isEmpty())
//            {
//                throw new InvalidOperationException("Sequence contains no elements");  
//            }
//            if (first == last)
//                first = last = null;                // if only one node in list
//            else
//            {
//                var previous = GetPrevious(last);   // save the previous node of the last node
//                Console.WriteLine("The last node '{0}' was removed", last.value);
//                last = previous;                    // set the last node to the previous node
//                last.next = null;
//            }
//            size--;
//        }

//        private Node GetPrevious(Node node)         // get previous node
//        {
//            var current = first;                    // start at the first node
//            while (current != null)                 // Meaning we haven't reached the end of the list
//            {
//                if (current.next == node)           // If the current node is the node we want
//                    return current;
//                current = current.next;             // Go to the next node
//            }
//            return null;
//        }

//        // contains (8)
//        public bool Contains(int item)
//        {
//            return IndexOf(item) != -1;    // See below... 
//        }

//        // indexOf (7)
//        public int IndexOf(int item)       //  This is qaulity, this is to iterate over an object that is not an enumerator or has no index 
//        {
//            int index = 0;
//            var current = first;
//            while (current != null)        // Meaning we haven't reached the end of the list
//            {
//                if (current.value == item)
//                    return index;
//                current = current.next;    // no need to write else
//                index++;
//            }
//            return -1;                     // just a flag that is used in contains above. It literally returns -1
//        }

//        //Size
//        public int Size()
//        {
//            return size;
//        }

//        //ToArray
//        public int[] ToArray()
//        {
//            int[] array = new int[size];            // create an array of the right size
//            var current = first;
//            int index = 0;
//            while (current != null)                 // Meaning we haven't reached the end of the list
//            {
//                array[index++] = current.value;     // add the value of the current node to the array
//                current = current.next;             // go to the next node
//            }
//            return array;
//        }

//        // Print (i did this)
//        public void Print()
//        {
//            var current = first;

//            while (current != null)
//            {
//                Console.WriteLine(current.value);
//                current = current.next;
//            }
//        }

//        private Boolean isEmpty()
//        {
//            return first == null;                    // if first is null, return empty
//        }


//        public void Reverse()
//        {
 

//            var current = first;

//            Node _previous;
//            Node _next;

//            while (current != null)
//            {
//                Console.WriteLine("Current Value : " + current.value);

//                if (current.previous != null)
//                    _previous = current.previous;

//                if (current.previous != null)
//                    _next = current.next;

//                if (current.previous != null)
//                {
//                    current.previous = current.next;
//                    Console.WriteLine("Previous Value : " + current.previous.value);
//                }


//                if (current.next != null)
//                {
//                    current.next = current.previous;
//                    Console.WriteLine("Next Value : " + current.next.value);
//                }


//                //{
//                //    _previous = current.previous;

//                //    current.previous = current.next;
//                //}

//                //Console.WriteLine(current.value + " " + current.previous.value);

//                // var nextVal = current.next;
//                // var prevValue = current.previous;


//                //     current.next = prevValue ?? null;
//                //     current.previous = nextVal ?? null;

//                current = current.next;
//            }
//            var head = first;
//            var tail = last;
//            first = tail;
//            head = last;
//        }



//        //public void Reverse()
//        //{


//        //    //first.previous = null;
//        //    //last.next = null;

//        //    var current = first;

//        //    while (current != null)
//        //    {
//        //        Console.WriteLine("Node {0}'s next node is {1}, and it's previous node is {2}", current, current.next, current.previous);

//        //        var _previous = current.previous;
//        //        var _next = current.next; 

//        //        if(current.previous != null)
//        //            current.previous = _next;
//        //        if(current.next != null)
//        //            current.next = _previous;

//        //        current = current.next;
//        //    }
//        //    var _last = last;
//        //    var _first = first;

//        //    first = _last;
//        //    last = _first;
//        //}
//    }
//}
