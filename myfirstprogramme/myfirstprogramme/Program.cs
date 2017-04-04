using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstprogramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(TimesByThree(7));
            
            Console.WriteLine(TimesByThree(x));
            if (IsDivisableBy(x, 3))
            {
                Console.WriteLine("That's even");
            }
            else
            {
                Console.WriteLine("That's odd");
            }
                /*   for (int i = 0; i < 100; i++)
               {


                   Console.WriteLine(i);
                   if (i % 3 ==0)
                   {
                       Console.Write("Fizz");
                   }
                   if (i % 5 == 0) 
                   {
                       Console.Write("Buzz");
                   }
                   if (i % 7 == 0) 
                   {
                       Console.Write("Bang");
                   }
                   if (i % 11 == 0) 
                   {
                       Console.Write("Bong");
                   }
                   Console.WriteLine();

               }

      /*     void TestStuff()
           {
               Console.WriteLine(1);
               Console.WriteLine("Good Day");
               String name = "Bob";
               Console.WriteLine(name);
               int magicnumber = int.Parse(Console.ReadLine());
               Console.WriteLine(magicnumber);
               if (magicnumber % 2 == 0)
               {
                   Console.WriteLine("Correct");
               }
               else
               {
                   Console.WriteLine("Incorrect");
               }*/

        }

        static int TimesByThree(int x)

        {
            return x * 3;
        }

        static bool IsDivisableBy(int x, int y)
        {    
            int remainder = x % y;
            return remainder ==0; 
        }


    
}
}
