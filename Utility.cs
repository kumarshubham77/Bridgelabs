using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Utility
    {
        public static void Anagram(string str1, string str2)
        {
            char[] char1 = str1.ToLower().ToCharArray();
            char[] char2 = str2.ToLower().ToCharArray();
            Console.WriteLine(char1);
            Array.Sort(char1);
            Array.Sort(char2);
            string newword1 = new string(char1);
            string newword2 = new string(char2);
            if (newword1 == newword2)
            {
                Console.WriteLine("They are annagram");
            }
            else
            {
                Console.WriteLine("Not a anagram sorry");
            }
        }
        public static void PrimeRange()
        {
            bool isprime = true;
            Console.WriteLine("Prime Numbers :");
            Console.WriteLine("Enter the upper limit :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lower limit :");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= m; i++)
            {
                for (int j = 2; j <= m; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine("\t" + i);
                }
                isprime = true;
            }
            Console.ReadKey();
        }
        public static void Palindome(int n)
        {
            int r;
            int sum = 0;
            int temp;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Non Palindrome");
            }
        }
        public static int BinarySearch(int[] arr, int key, int low, int high)
        {
            while (low <= high)
            {




                int mid = (low + high) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    BinarySearch(arr, key, low, mid - 1);
                }
                else
                {
                    BinarySearch(arr, key, mid + 1, high);
                }
            }
            return -1;
        }
        public static int BinaryString(string[] arr, string x)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = (l + (r - l) / 2);
                int res = x.CompareTo(arr[m]);
                if (res == 0)
                {
                    return m;
                }
                else if (res > 0)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }

            }
            return -1;
        }
        /// <summary>
        /// Vendings the machine.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void VendingMachine(int N)
        {
            int ONE = 1;
            int TWO = 2;
            int FIVE = 5;
            int TEN = 10;
            int FIFTY = 50;
            int HUNDRED = 100;
            int FIVEHUNDERED = 500;
            int THOUSAND = 1000;
            
            int tempmoney = N;
            while (tempmoney > 0)
            {
                int noofnotes = 0; 
                if (tempmoney > 1000)
                {
                    noofnotes += tempmoney / THOUSAND;
                    tempmoney = tempmoney % THOUSAND;
                    Console.WriteLine("No. of Thousand Rupees Note is :" +noofnotes);
                }
                else if (tempmoney >= FIVEHUNDERED && tempmoney < THOUSAND)
                {
                    noofnotes += tempmoney / FIVEHUNDERED;
                    tempmoney = tempmoney % FIVEHUNDERED;
                    Console.WriteLine("No. of Five Hundred Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= HUNDRED && tempmoney < FIVEHUNDERED)
                {
                    noofnotes += tempmoney / HUNDRED;
                    tempmoney = tempmoney % HUNDRED;
                    Console.WriteLine("No. of Hundred Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= FIFTY && tempmoney < HUNDRED)
                {
                    noofnotes += tempmoney / FIFTY;
                    tempmoney = tempmoney % FIFTY;
                    Console.WriteLine("No. of Fifty Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= TEN && tempmoney < FIFTY)
                {
                    noofnotes += tempmoney / TEN;
                    tempmoney = tempmoney % TEN;
                    Console.WriteLine("No. of Ten Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= FIVE && tempmoney < TEN)
                {
                    noofnotes += tempmoney / FIVE;
                    tempmoney = tempmoney % FIVE;
                    Console.WriteLine("No. of Five Rupees Note is :" + noofnotes);
                }
                else if (tempmoney >= TWO && tempmoney < FIVE)
                {
                    noofnotes += tempmoney / TWO;
                    tempmoney = tempmoney % TWO;
                    Console.WriteLine("No. of Two Rupees Note is :" + noofnotes);
                }
                else
                {
                    noofnotes += tempmoney / ONE;
                    tempmoney = tempmoney % ONE;
                    Console.WriteLine("No. of One Rupees Note is :" + noofnotes);
                }
                Console.WriteLine("Minimum number of notes to be given is " + noofnotes);

            }
            

        }
        public static void DayOfWeek(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            if(d0 == 0)
            {
                Console.WriteLine("Sunday");
            }
            else if (d0 == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (d0 == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (d0 == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (d0 == 4)
            {
                Console.WriteLine("Thrusday");
            }
            else if (d0 == 5)
            {
                Console.WriteLine("Friday");
            }
            else
            {
                Console.WriteLine("Saturday");
            }
            Console.WriteLine("Value of d0 = "+ d0);
        }
       
        
        public class Vending
        {
            int total = 0;
            int[] arr = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int sum = 0;
            int i = 0;
            int v = 0;
             public void check(int n)
            {
                if(n!=0)
                {
                    for(int i =0;i<arr.Length;i++)
                    {
                        if (n <arr[i])
                        {
                            //int v = arr[i - 1];
                            divide(n, arr[i - 1]);
                            
                            break;
                        }
                    }
                    if (n>1000)
                    {
                        divide(n, 1000);
                    }
                }
                
                  void divide(int note,int nearvalue)
                {
                    if(note!=0)
                    {
                        int sum = 0;
                        sum = sum + note / nearvalue;
                        total = total + sum;
                        int num = note % nearvalue;
                        Console.WriteLine("Value is "+v +"this" + sum);
                        check(num);
                    }
                }
                 //void show()
                {
                    Console.WriteLine("Total note = " + total);
                }
            }
            
        }
        public static void InsertionNumber()
        {
            int i, n;
            int j, val, flag;
            Console.WriteLine("Enter the number of total elements you want to add");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int k =0;k < n;k++)
            {
                arr[k] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Insertion Sort "+arr);
            Console.WriteLine("Initial array :");
            for(i = 0;i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for(i =1;i<n;i++)
            {
                val = arr[i];
                flag = 0;
                for(j=i-1;j>=0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("sorted");
            for(i =0;i<n;i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
