﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2
{
    class Program
    {
        static void Main(string[] args)
        {
               //O(1+1+N*N*N) = O(2N^3)
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }
    }
}