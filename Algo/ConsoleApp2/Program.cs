using FizzBizz;
using MaximizeProfit;
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
            MaximizeProfitClass mpc = new MaximizeProfitClass();
            FizzBizzClass fz = new FizzBizzClass();



            int a = Int32.Parse(Console.ReadLine());
            string[] temp = new string[a];
            temp = Console.ReadLine().Split(' ');

            List<int> at = new List<int>();
            foreach (string astr in temp)
            {
                at.Add(Int32.Parse(astr));
            }


            Console.WriteLine(mpc.getMaximumProfit(at, temp));
            

            
            Console.ReadLine();
        }
    }
}
