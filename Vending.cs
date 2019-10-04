using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Vending
    {
        int total = 0;
        int[] arr = { 1, 2, 5, 10, 50, 100, 200, 500, 1000 };
        public void check(int n)
        {
            if (n != 0)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    //Console.WriteLine("Entered");
                    if (n < arr[i])
                    {
                        Divide(n, arr[i - 1]);
                        break;
                    }
                }
                if (n > 1000)
                {
                    Divide(n, 1000);
                }
            }
            void Divide(int note, int nearvalue)
            {
                int sum = 0;
               
                if (n != 0)
                {
                    sum =sum + note / nearvalue;
                    total = total + sum;
                    int num = note % nearvalue;
                    Console.WriteLine("number of"+nearvalue +"is-->"+sum);
                    check(num);
                }
               
            }
            Console.WriteLine("Total number of cash -->" + total);
        }
      
    }
}