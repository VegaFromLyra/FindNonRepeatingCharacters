using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Find the first non-repeating character from a stream of characters
// in O(1) time
namespace FindNonRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "geeksforgeeks";

            Console.WriteLine("The first non repeating character is {0}", FindFirstNonRepeatingChar(input));
        }

        static char FindFirstNonRepeatingChar(string input)
        {
            bool[] repeated = new bool[256];

            LinkedList<char> list = new LinkedList<char>();

            Dictionary<char, LinkedListNode<char>> table = new Dictionary<char, LinkedListNode<char>>();

            foreach (char ch in input)
            {
                if (repeated[ch] == false)
                {
                    if (table.ContainsKey(ch))
                    {
                        repeated[ch] = true;
                        list.Remove(ch);
                    }
                    else
                    {
                        LinkedListNode<char> node = list.AddLast(ch);
                        table.Add(ch, node);
                    }
                }
            }

            return list.First.Value;
        }
    }
}
