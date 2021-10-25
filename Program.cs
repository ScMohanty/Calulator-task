using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        int i;
        int j;
        string d;
        static void Addition(int i, int j, out int result)
        {
            i = i;
            j = j;
            result = i + j;
        }
        static void Multipication(int i, int j, out int result1)
        {
            i = i;
            j = j;
            result1 = i * j;
        }
        static void Substraction(int i, int j, out int result2)
        {
            i = i;
            j = j;
            result2 = i - j;
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            do
            {
                Console.WriteLine("ENTER THE ");
                Console.WriteLine("PRESS 1 FOR ADDITION");
                Console.WriteLine("PRESS 2 FOR MULTIPICATION");
                Console.WriteLine("PRESS 3 FOR SUBSTRACTION");
                int enter;
                enter = Convert.ToInt32(Console.ReadLine());




                switch (enter)
                {
                    case 1:

                        int result = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Addition(p.i, p.j, out result);
                        Console.WriteLine(result);


                        break;

                    case 2:
                        int result1 = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Multipication(p.i, p.j, out result1);
                        Console.WriteLine(result1);
                        break;

                    case 3:
                        int result2 = 0;
                        Console.WriteLine("enter 1st number");
                        p.i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter 2nd number");
                        p.j = Convert.ToInt32(Console.ReadLine());
                        Substraction(p.i, p.j, out result2);
                        Console.WriteLine(result2);
                        break;

                }

                Console.WriteLine("DO YOU WANT ANYTHING ELSE");
                Console.WriteLine("If you want press Y/y");
                
               p. d = Console.ReadLine();
                

               // enter = Convert.ToInt32(Console.ReadLine());


            }
            while (p.d=="Y"||p.d=="y");
           
            }
        }



    }

