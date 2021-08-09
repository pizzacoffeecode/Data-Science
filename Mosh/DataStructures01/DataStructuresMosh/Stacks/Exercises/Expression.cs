//using System;
//using System.Collections.Generic;
//using System.Text;

//// !!! INTERVIEW QUESTION
//namespace DataStructuresMosh.Stacks.Exercises
//{
//   public class Expression
//   {
//       List<Char> leftBrackets = new List<Char>{ '{', '(', '[', '<' };
//       List<Char> rightBrackets = new List<Char>{ '}', ')', ']', '>' };
//       public bool IsBalanced(String input)
//       {
//           Stack<Char> stack = new Stack<Char>();                           // Stack to store the characters

//           foreach (char ch in input.ToCharArray()){                        // For each character in the input string

//                if (isLeftBracket(ch))                                       // If the character is a left bracket
//                {
//                    stack.Push(ch);
//                }

//                if (isRightBracket(ch)){
//                    if (isEmpty(stack)) return false;
                    
//                    var top = stack.Pop();
//                    if (!bracketsMatch(top, ch)) return false;
//                }
//           }
//           return !isEmpty(stack);           
//       }

//        private bool isEmpty(Stack<Char> stack)
//        {
//            Console.WriteLine(stack.Count);
//            return stack.Count == 0;
//        }
//        private bool isLeftBracket(char ch)
//        {
//            return leftBrackets.Contains(ch);                               // If the character is a left bracket, return true
//        }
//        private bool isRightBracket(char ch)
//        {
//            return rightBrackets.Contains(ch);                              // If the character is a right bracket, return true
//        }
//        private bool bracketsMatch(char left, char right){                  // Function to check if the two brackets match
//        return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);  // This code is great, replaces all this below...
                                                                        
//        // return  (right == ')' && left != '(') ||
//        //         (right == ']' && left != '[') ||
//        //         (right == '}' && left != '{') ||
//        //         (right == '>' && left != '<');
//        }
//   }
//    class program
//    {
//        static void Main()
//        {
//            // Edge Cases
//            // (
//            // (()
//            // ) ()

//            String str = " ";
//            Expression exp = new Expression();

//            var result = exp.IsBalanced(str);

//            Console.WriteLine(result);
//        }
//    }
//}
