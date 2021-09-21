//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructuresMosh.Queues
//{
//    class Program
//    {
//        static void Main()
//        {
//            Queue<int> q = new Queue<int>();

//            q.Enqueue(10);
//            q.Enqueue(20);
//            q.Enqueue(30);
//            Reverse(q);
//        }

//        static void Reverse(Queue<int> inQ)
//        {
//            var s = new Stack<int>();
//            var outQ = new Queue<int>();

//            while (inQ.Count > 0)
//            {
//                var temp = inQ.Dequeue();
//                s.Push(temp);
//            }

//            while (s.Count > 0)
//            {
//                outQ.Enqueue(s.Pop());
//            }
//            Console.WriteLine(string.Join(",", outQ));
//        }
//    }
//}
