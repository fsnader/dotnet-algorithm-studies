using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsPractice.Codility.Lesson7_StacksAndQueues
{
    /*
    A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

    S is empty;
    S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
    S has the form "VW" where V and W are properly nested strings.
    For example, the string "{[()()]}" is properly nested but "([)()]" is not.

    Write a function:

    class Solution { public int solution(string S); }

    that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

    For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

    Write an efficient algorithm for the following assumptions:

    N is an integer within the range [0..200,000];
    string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
     */
    public static class Brackets
    {
        public static char[] closingBraces = new char[] { '}', ']', ')' };

        public static int IsNested(string input)
        {
            var stack = new Stack<char>();

            foreach(char c in input)
            {
                if (!closingBraces.Contains(c))
                {
                    stack.Push(c);
                    continue;
                }

                if (stack.Count == 0 || !AreClosingPairs(stack.Pop(), c))
                {
                    return 0;
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }

        private static bool AreClosingPairs(char opening, char closing)
        {
            switch (opening)
            {
                case '{':
                    return closing == '}';
                case '[':
                    return closing == ']';
                case '(':
                    return closing == ')';
                default:
                    return false;
            }
        }
    }
}
