using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.if_stateent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the test can either be true or false
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are female");
            }
            //can also test 2 conditions with i.e && in C#, or is ||
            bool isTall = false; 
            if (isMale && isMale) 
            {
                Console.WriteLine("You are both male and tall");
            }
            else if (!isTall && isMale) 
            {
                Console.WriteLine("You are not tall but you are male");
            }
            else 
            {
                Console.WriteLine("You are either not tall or not a male");
            }
            Console.ReadLine();
        }
    }
}
