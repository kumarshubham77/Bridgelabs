using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Merge
    {
        static public void Merges(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] Left = new int[n1];
            int[] Right = new int[n2];
            for(i =0;i<n1;i++)
            {
                Left[i] = arr[p + i];
            }
            for(j =0;j<n2;j++)
            {
                Right[j] = arr[q + 1 + j];
            }
            i= 0;
            j = 0;
            k = p;
            while (i<n1 && j <n2)
            {
                if (Left[i]<=Right[j])
                {
                    arr[k] = Left[i];
                    i++;
                }
                else
                {
                    arr[k] = Right[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                arr[k] = Left[i];
                i++;
                k++;
            }
            while(j<n2)
            {
                arr[k] = Right[j];
                j++;
                k++;
            }
        }
        static public void MergeSort(int[] arr,int p, int r)
        {
            if(p<r)
            {
                int q = (p + r) / 2;
                MergeSort(arr, p, q);
                MergeSort(arr, q + 1, r);
                Merges(arr, p, q, r);
            }
        }
    }
}
