﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Factor
    {
        public void Factors()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i =2;i < num; i++)
            {
                while(num % i == 0)
                {
                    num = num / i;
                    Console.WriteLine(i);
                }
            }
            if(num != 1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
