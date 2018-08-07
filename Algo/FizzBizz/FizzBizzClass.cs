using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBizz
{
    public class FizzBizzClass

    {

        public void Arrange(List<int> at)
        {
            foreach (int h in at)
            {
                for (int j = 1; j <= h; j++)
                {
                    if (j % 3 == 0 && j % 5 != 0)
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
        }
    }
}
