using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoder
{
    //Program that encodes & decodes an entered string
    //Only works for numbers 0-9 and letters a-z
    //Letters are all converted to lowercase when encoded/decoded
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string test = Console.ReadLine();
            string encoded = "";
            string decoded = "";

            test = test.ToLower();

            Console.WriteLine("Original string: " + test);

            foreach (char c in test)
            {
                foreach (KeyValuePair<char, char> letter in codes)
                {
                    if (letter.Key == c)
                        encoded += letter.Value;
                }
            }
            Console.WriteLine("Encoded string:  " + encoded);

            foreach (char c in encoded)
            {
                foreach (KeyValuePair<char, char> letter in codes)
                {
                    if (letter.Value == c)
                        decoded += letter.Key;
                }
            }
            Console.WriteLine("Decoded string:  " + decoded);
        }
        public static Dictionary<char, char> codes = new Dictionary<char, char>()
        {
            { 'a', '0' },
            { 'b', '1' },
            { 'c', '2' },
            { 'd', '3' },
            { 'e', '4' },
            { 'f', '5' },
            { 'g', '6' },
            { 'h', '7' },
            { 'i', '8' },
            { 'j', '9' },
            { 'k', '~' },
            { 'l', '!' },
            { 'm', '@' },
            { 'n', '#' },
            { 'o', '$' },
            { 'p', '%' },
            { 'q', '^' },
            { 'r', '&' },
            { 's', '*' },
            { 't', '(' },
            { 'u', ')' },
            { 'v', '-' },
            { 'w', '_' },
            { 'x', '=' },
            { 'y', '+' },
            { 'z', '[' },
            { '1', ']' },
            { '2', '{' },
            { '3', '}' },
            { '4', ',' },
            { '5', '<' },
            { '6', '>' },
            { '7', '?' },
            { '8', ':' },
            { '9', ';' },
            { ' ', ' ' },
        };
    }
}