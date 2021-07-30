//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DataStructuresMosh.Linked_Lists
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var list = new MyLinkedList();

//            Console.WriteLine("the Linked List is of size {0}", list.Size());
//            list.AddLast(10);
//            list.AddLast(20);
//            list.AddLast(30);
//            list.Print();
//            Console.WriteLine("The item you searched for is index {0}", list.IndexOf(30));
//            Console.WriteLine("the Linked List is of size {0}", list.Size());
//            Console.WriteLine("Item in Linked List = {0}", list.Contains(20));
//            list.RemoveLast();
//            list.Print();
//            Console.WriteLine("the Linked List is of size {0}", list.Size());

//            var array = list.ToArray();
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine("copied array item {0} = {1}", i, array[i]);
//            }

//        }

//    }
//}
