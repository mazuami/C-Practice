using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            List<int> at = new List<int>();


            foreach (string astr in temp)
            {
                at.Add(Int32.Parse(astr));
            }

            

            

            foreach(int h in at)
            {
                for (int j = 1; j <= h; j++)
                {
                    if (j % 3 == 0 && j % 5 !=0  )
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (j % 5 == 0 && j % 3 != 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (j % 5 == 0 && j % 3 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
