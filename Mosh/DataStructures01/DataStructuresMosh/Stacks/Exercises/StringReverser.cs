//using System;
//using System.Collections.Generic;
//using System.Text;

//// !!! INTERVIEW QUESTION
//namespace DataStructuresMosh.Stacks.Exercises
//{
//    public class StringReverser
//    {
//        public String Reverse(String input)
//        {
//            if (input == null || input == "")
//            {
//                Console.WriteLine("You must enter a string");
//                Console.ReadKey();
//                throw new ArgumentException("You must enter a string");
//            }

//            Console.WriteLine(input);

//            Stack<Char> stack = new Stack<Char>();

//            foreach (Char ch in input.ToCharArray())
//            {
//                stack.Push(ch);
//            }

//            //// This way is less efficient as it reqiures lots of concatinations, better method below...
//            //String reversed = "";
//            //while (stack.Count > 0)
//            //{
//            //    reversed += stack.Pop();
//            //}

//            StringBuilder reversed = new StringBuilder();
//            while (stack.Count > 0)
//            {
//                reversed.Append(stack.Pop());
//            }

//            Console.WriteLine(reversed);
//            string _reversed = reversed.ToString();
//            return _reversed;
//        }

//        class program
//        {
//            static void Main()
//            {
//                StringReverser stringRev = new StringReverser();

//                stringRev.Reverse("Monkey");
//            }
//        }
//    }
//}
