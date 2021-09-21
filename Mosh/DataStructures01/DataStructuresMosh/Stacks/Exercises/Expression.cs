using System;
using System.Collections.Generic;
using System.Text;



// !!! INTERVIEW QUESTION
namespace DataStructuresMosh.Stacks.Exercises
{
    public class Expression
    {
        List<Char> leftBrackets = new List<Char> { '{', '(', '[', '<' };    // An List of possible left bracket characters
        List<Char> rightBrackets = new List<Char> { '}', ')', ']', '>' };   // Same for right
        public bool IsBalanced(String input)
        {
            Stack<Char> stack = new Stack<Char>();                          // Stack to store the characters

            foreach (char ch in input.ToCharArray())
            {                                                               // For each character in the input string

                if (isLeftBracket(ch))                                      // If the character is a left bracket
                {
                    stack.Push(ch);
                }

                if (isRightBracket(ch))
                {
                    if (isEmpty(stack)) return false;                       // If the stack is empty (i.e. no left) and we have a right bracket then not equal

                    var top = stack.Pop();
                    if (!bracketsMatch(top, ch)) return false;              // If we have both brackets and they don't match return false
                }
            }
            return isEmpty(stack);                                          // If neighter a left or right bracket a stack is isEmpty return true. It's
                                                                            // equal since there were no false conditions
        }

        // Helper Function I wrote. No isEmpty in c#
        private bool isEmpty(Stack<Char> stack)
        {
            Console.WriteLine(stack.Count);
            return stack.Count == 0;
        }

        // Functions
        private bool isLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);                               // If the character is a left bracket, return true
        }
        private bool isRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);                              // If the character is a right bracket, return true
        }
        private bool bracketsMatch(char left, char right)
        {                  // Function to check if the two brackets match
            return leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);  // This code is great, replaces all this below...

            // return  (right == ')' && left != '(') ||
            //         (right == ']' && left != '[') ||
            //         (right == '}' && left != '{') ||
            //         (right == '>' && left != '<');
        }
    }
    class program
    {
        static void Main()
        {
            // Edge Cases
            // (
            // (()
            // ) ()

            String str = "({})";
            Expression exp = new Expression();

            var result = exp.IsBalanced(str);

            Console.WriteLine(result);
        }
    }
}
