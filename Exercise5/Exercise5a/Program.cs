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

        public static bool IsUper(char c)
        {
            return false;
        }
        public static bool IsLower(char c)
        {
            return false;
        }
        public static char ToUper(char c)
        {
            return c;
        }
        public static char ToLower(char c)
        {
            return c;
        }
    }
}