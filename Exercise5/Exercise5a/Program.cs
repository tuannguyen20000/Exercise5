using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isUpper('a'));            
            Console.WriteLine(isLower('a'));
            Console.WriteLine(toLower('A'));
            Console.WriteLine(toUpper('a'));
        }
        public static void PrintABCD()
        {
            for (int i = 97; i < 123; i++)
            {
                Console.WriteLine((char)i);
            }
            for (int i = 122; i > 96; i--)
            {
                Console.WriteLine((char)i);
            }
            for (int i = 65; i < 91; i++)
            {
                Console.WriteLine((char)i);
            }

            for (int i = 128; i < 255; i++)
            {
                Console.WriteLine((char)i);
            }

        }
        public static int Char2Code(char c)
        {
            return (int)c;
        }
        public static bool isUpper(char e)
        {
            for (int i = 65; i <= 90; i++)
            {               
                if (e.Equals((char)i))
                    return true;
            }
            return false;
        }
        public static bool isLower(char a)
        {
            for (int i = 65; i <= 90; i++)
            {              
                if (a.Equals((char)i))
                    return false;
            }
            return true;
        }
        public static char toUpper(char a)
        {
            int c = Char2Code(a);
            c = c - 32;
            a = (char)c;
            return a;

        }
        public static char toLower(char a)
        {
            int c = Char2Code(a);
            c = c + 32;
            a = (char)c;
            return a;
        }
    }
}