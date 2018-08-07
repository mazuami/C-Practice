using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizeProfit
{
    public class MaximizeProfitClass
    {
       
        List<int> sum = new List<int>();

        public int getMaximumProfit(List<int> at,string[] temp)
        {
            foreach (string astr in temp)
            {

                at.Add(Int32.Parse(astr));
            }

            int max_sum = 0;

            if (at[0] == 1)
            {
                max_sum = max_sum + 1;
            }

            for (int i = 0; i < at.Count; i++)
            {
                if (at[i] != 1)
                {

                    max_sum = max_sum + at[i];
                    for (int j = 0; j <= at.Count - 1; j++)
                    {
                        if (at[j] > at[i])
                        {
                            if (at[j] % at[i] == 0)
                            {
                                max_sum = max_sum + at[j];


                            }
                        }

                    }
                    sum.Add(max_sum);

                    if (at[0] == 1)
                    {
                        max_sum = 1;
                    }
                    else
                    {
                        max_sum = 0;
                    }
                }
            }
            int maximum = 0;
            for (int i = 0; i < sum.Count - 1; i++)
            {
                if (sum[i] > maximum)
                    maximum = sum[i];
            }

            Console.WriteLine(maximum);

            return maximum;
        }



    }
}
