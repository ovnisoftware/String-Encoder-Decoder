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
            bool KeepGoing = true;
            while (KeepGoing)
            {
                Console.WriteLine();
                Console.WriteLine("Do you want to encode or decode?");
                Console.WriteLine("Type 'e' for encode or 'd' for decode:");
                string encodeDecode = Console.ReadLine();
                if (encodeDecode == "e")
                {
                    Console.Write("Please enter a string to encode: ");
                    string entry = Console.ReadLine();
                    string encoded = "";

                    entry = entry.ToLower();

                    foreach (char c in entry)
                    {
                        foreach (KeyValuePair<char, char> letter in codes)
                        {
                            if (letter.Key == c)
                                encoded += letter.Value;
                        }
                    }
                    Console.WriteLine("Encoded string:  " + encoded);
                }
                else if (encodeDecode == "d")
                {
                    Console.Write("Please enter a string to decode: ");
                    string entry = Console.ReadLine();
                    string decoded = "";

                    foreach (char c in entry)
                    {
                        foreach (KeyValuePair<char, char> letter in codes)
                        {
                            if (letter.Value == c)
                                decoded += letter.Key;
                        }
                    }
                    Console.WriteLine("Decoded string:  " + decoded);
                }
                else
                    Console.WriteLine("Please enter 'e' or 'd'");
            }
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